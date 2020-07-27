using UnityEngine;

public class TestRunner : NUnit.Framework.Interfaces.ITestListener
{
    public void TestStarted(NUnit.Framework.Interfaces.ITest test)
    {
        Debug.Log("Test started");
    }

    public void TestFinished(NUnit.Framework.Interfaces.ITestResult result)
    {
        Debug.Log("Test finished");
    }

    public void TestOutput(NUnit.Framework.Interfaces.TestOutput output)
    {
        Debug.Log("Test output");
    }
}
