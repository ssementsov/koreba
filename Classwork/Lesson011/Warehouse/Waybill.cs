using System;
using System.Collections.Generic;

namespace Lesson011.Warehouse
{
    public class Waybill
    {
        private uint _id;
        private List<Waybill_Line> _body;
        private string _signatureFrom;
        private string _signatureTo;

        public Waybill(uint id, Worker from, Worker to, Dictionary<Product, uint> products)
        {
            _id = id;
            From = from;
            To = to;
            DateOfCreation = DateTime.Now;
            _body = new List<Waybill_Line>();

            uint lineID = 1;
            foreach (KeyValuePair<Product, uint> productType in products)
            {
                var line = new Waybill_Line(lineID++, productType.Key, productType.Value);
                _body.Add(line);
            }
        }

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

        public Waybill_Line GetLine(int id)
        {
            return id >= 0 ? _body[id] : throw new ArgumentException("There is no line with this number on the waybill");
        }
    }
}
