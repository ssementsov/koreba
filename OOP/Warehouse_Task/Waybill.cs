using System;
using System.Collections.Generic;

namespace Warehouse_Task
{
    public class Waybill
    {
        private uint _lineID = 1;

        private uint _id;
        private List<Waybill_Line> _body;
        private string _signatureFrom;
        private string _signatureTo;

        public DateTime DateOfCreation { get; private set; }
        public Worker From { get; private set; }
        public Worker To { get; private set; }

        public string SignatureFrom
        {
            get => _signatureFrom;
            set => TryFillSignatureField(ref _signatureFrom, value);
        }

        public string SignatureTo
        {
            get => _signatureTo;
            set => TryFillSignatureField(ref _signatureTo, value);
        }

        public Waybill(uint id, Worker from, Worker to)
        {
            _id = id;
            From = from;
            To = to;
            DateOfCreation = DateTime.Now;
            _body = new List<Waybill_Line>();
        }

        public Waybill(uint id, Worker from, Worker to, Dictionary<Product, uint> products)
            : this(id, from, to)
        {
            foreach (KeyValuePair<Product, uint> productType in products)
            {
                var line = new Waybill_Line(_lineID++, productType.Key, productType.Value);
                _body.Add(line);
            }
        }

        public Waybill_Line GetLine(int id)
        {
            return id >= 0 ? _body[id] : throw new ArgumentException("There is no line with this number on the waybill");
        }

        public int GetSize()
        {
            return _body.Count;
        }

        public void AddPosition(Product product, uint count)
        {
            var line = new Waybill_Line(_lineID++, product, count);
            _body.Add(line);
        }

        public override string ToString()
        {
            string result = $"\n {string.Empty, 80} \"{DateOfCreation:dd}\" {DateOfCreation:MMMM yyyy} \n\n" +
                $"{"WAYBILL №", 55}{_id} \n\n" +
                $"{"From: ", -10}{From.Name} \n" +
                $"{"To: ", -10}{To.Name} \n";

            string horizontalLine = GetHorizontalLine();

            result += horizontalLine + "\n";
            result += $"\n{string.Empty,-3}{"№"}{string.Empty,-3}{"|",-3}{"Product name",-60}{"|",-5}{"Count",-5}{"|",-5}{"Price",-5}{"|",-5}{"Sum",-5}\n";
            result += horizontalLine + "\n";

            foreach (Waybill_Line line in _body)
            {
                result += line.ToString() + horizontalLine + "\n";
            }

            result += $"\n\n {"Place of signature",-30} Release: {SignatureFrom, -30} Accept: {SignatureTo}";

            return result;
        }

        private string GetHorizontalLine()
        {
            string horizontalLine = string.Empty;

            if (_body.Count > 0)
            {
                int width = _body[0].ToString().Length;

                for (int i = 0; i < width; i++)
                {
                    horizontalLine += "_";
                }
            }
            else
            {
                horizontalLine = "_";
            }

            return horizontalLine;
        }

        private void TryFillSignatureField(ref string signatureField, string value)
        {
            if (signatureField == null)
            {
                signatureField = value;
            }
            else
            {
                Console.WriteLine("You can't forge a signature!");
            }
        }
    }
}
