/// <summary>
/// RunType - A means to partition the stages of the object semantics. 
/// IMock.IRunType contains SUCCESS = 0 & EXCPTION = 1 properties so we can add some 
/// specific ones applicable to out Mock object
/// </summary>
public class RunType : IRunType
{
    public static int FAIL_Ping { get { return -1; } }
    public static int FAIL_Display { get { return -2; } }
}
