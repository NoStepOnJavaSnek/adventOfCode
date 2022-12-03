using RSP;

public class RSPScorerTest
{
    [Fact]
    public void GetScore_ShouldCalculateExample_To15Points()
    {
        const int expectedScore = 15;
        const String stubInput = @"A Y
B X
C Z";

        int actualGameScore = new RSPScorer(stubInput).GetScore();

        Assert.Equal(expectedScore, actualGameScore);
    }
}