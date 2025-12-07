namespace ConsoleApp.LeanToCode_Program;

public class LearnOne
{
    public async Task<LearnOne> GetLearnOneAsync()
    {
        var result = new LearnOne();
        return await Task.FromResult(result);
    }
}