using Anotar.MetroLog;
using MetroLog;

public class ClassWithExistingField
{
    static ILogger existingLogger;

    static ClassWithExistingField()
    {
		existingLogger = LogManagerFactory.DefaultLogManager.GetLogger("ClassWithExistingField");
    }

    public void Debug()
    {
        LogTo.Debug();
    }
}