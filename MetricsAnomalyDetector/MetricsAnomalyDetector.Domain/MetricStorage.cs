namespace MetricsAnomalyDetector.Domain
{
    public class MetricStorage : IAggregateRoot
    {
        public MetricStorage(string name, string url)
        {
            Name = name;
            Url = url;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Url { get; private set; }
    }
}
