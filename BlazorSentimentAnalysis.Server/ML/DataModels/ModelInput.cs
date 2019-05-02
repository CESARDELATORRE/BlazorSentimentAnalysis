using Microsoft.ML.Data;

namespace BlazorSentimentAnalysis.Server.ML.DataModels
{
    public class ModelInput
    {
        [ColumnName("sentiment_label"), LoadColumn(0)]
        public bool SentimentLabel { get; set; }


        [ColumnName("tweet_en"), LoadColumn(1)]
        public string Text { get; set; }


    }
}
