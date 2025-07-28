namespace MetricsAnomalyDetector.Domain
{
    public interface IPredictor
    {
        Task<AnomalyPrediction> DetectAnomalies(TimeSeriesData[] timeSeries);
    }

    public class TimeSeriesData
    {
        public DateTime Timestamp { get; init; }
        public float Value { get; init; }
    }

    public class AnomalyPrediction
    {        
        public double[] Prediction { get; init; }
    }
}
