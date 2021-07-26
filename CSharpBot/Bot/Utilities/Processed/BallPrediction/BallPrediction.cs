namespace Bot.Utilities.Processed.BallPrediction
{

#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
    /// <summary>
    /// Processed version of the <see cref="rlbot.flat.BallPrediction"/> that uses sane data structures.
    /// </summary>
    // Just like the Packet class, this class is here for your convenience.
    // It is NOT part of the framework and you can change it as much as you want, or delete it entirely.
    public struct BallPrediction
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
    {
        public PredictionSlice[] Slices;
        public int Length => Slices.Length;

        public BallPrediction(rlbot.flat.BallPrediction ballPrediction)
        {
            Slices = new PredictionSlice[ballPrediction.SlicesLength];
            for (int i = 0; i < ballPrediction.SlicesLength; i++)
                Slices[i] = new PredictionSlice(ballPrediction.Slices(i).Value);
        }
    }
}