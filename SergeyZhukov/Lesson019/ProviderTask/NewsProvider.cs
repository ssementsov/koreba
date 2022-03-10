using Lesson019.ProviderTask.News;

namespace Lesson019.ProviderTask
{
    internal class NewsProvider
    {
        public event Action<SimpleNews> News;
        public event Action<WeatherNews> Weather;
        public event Action<SportNews> Sport;
        public event Action<AccidentsNews> Accidents;
        public event Action<HumorNews> Humor;
        public void NewsPublication(AbstractNews news)
        {
            if (news is SimpleNews simple)
            {
                News?.Invoke(simple);
            }
            else if (news is WeatherNews weather)
            {
                Weather?.Invoke(weather);
            }
            else if (news is SportNews sport)
            {
                Sport?.Invoke(sport);
            }
            else if (news is AccidentsNews accidents)
            {
                Accidents?.Invoke(accidents);
            }
            else if (news is HumorNews humor)
            {
                Humor?.Invoke(humor);
            }
        }
    }
}
