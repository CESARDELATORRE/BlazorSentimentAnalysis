//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace TwitterSentiment.Model.DataModels
{
    public class ModelInput
    {
        [ColumnName("sentiment_label"), LoadColumn(0)]
        public bool Sentiment_label { get; set; }


        [ColumnName("tweet_en"), LoadColumn(1)]
        public string Tweet_en { get; set; }


    }
}
