using Lesson019.ProviderTask;
using Lesson019.ProviderTask.News;

namespace Lesson019
{
    internal class NewsProviderExample
    {
        public void ExecuteTask()
        {
            var provider = new NewsProvider();
            var client = new Client(provider);

            client.Subscribe<WeatherNews>();

            SportNews sportNews = new SportNews();
            WeatherNews weatherNews = new WeatherNews();

            provider.NewsPublication(sportNews);
            provider.NewsPublication(weatherNews);

            client.Unsubscribe<WeatherNews>();
        }
    }
}
