using Lesson019.ProviderTask.News;

namespace Lesson019.ProviderTask
{
    internal class Client
    {
        private NewsProvider _provider;
        public Client(NewsProvider provider)
        {
            _provider = provider;
        }
        public void Subscribe<T>() where T : AbstractNews
        {
            if (typeof(T) == typeof(SimpleNews))
            {
                _provider.News += ReceiveNews;
            }
            else if (typeof(T) == typeof(WeatherNews))
            {
                _provider.Weather += ReceiveNews;
            }
            else if (typeof(T) == typeof(SportNews))
            {
                _provider.Sport += ReceiveNews;
            }
            else if (typeof(T) == typeof(AccidentsNews))
            {
                _provider.Accidents += ReceiveNews;
            }
            else if (typeof(T) == typeof(HumorNews))
            {
                _provider.Humor += ReceiveNews;
            }
        }

        public void Unsubscribe<T>() where T : AbstractNews
        {
            if (typeof(T) == typeof(SimpleNews))
            {
                _provider.News -= ReceiveNews;
            }
            else if (typeof(T) == typeof(WeatherNews))
            {
                _provider.Weather -= ReceiveNews;
            }
            else if (typeof(T) == typeof(SportNews))
            {
                _provider.Sport -= ReceiveNews;
            }
            else if (typeof(T) == typeof(AccidentsNews))
            {
                _provider.Accidents -= ReceiveNews;
            }
            else if (typeof(T) == typeof(HumorNews))
            {
                _provider.Humor -= ReceiveNews;
            }
        }

        public void ReceiveNews(AbstractNews news)
        {
            string s = $"Received {news.GetType()}";
            Console.WriteLine(s);
        }
    }
}
