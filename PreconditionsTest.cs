[TestClass]
public class PreconditionsTest
{
    [TestMethod]
    public void TestCheckNotNullThrowsNullReferenceExceptionForNullReference()
    {
        try
        {
            Preconditions.CheckNotNull((string)null, "reference: null");
            Assert.Fail("Expected NullReferenceException");
        }
        catch (NullReferenceException e)
        {
        }
    }

    [TestMethod]
    public void TestCheckNotNullSetsErrorMessageForNullReference()
    {
        try
        {
            Preconditions.CheckNotNull((string)null, "reference: null");
            Assert.Fail("Expected NullReferenceException");
        }
        catch (NullReferenceException e)
        {
            Assert.AreEqual("reference: null", e.Message);
        }
    }

    [TestMethod]
    public void TestCheckNotNullReturnsReferenceWhenNotNull()
    {           
        string reference = "Hi I'm a string.";
        Assert.AreEqual(reference, Preconditions.CheckNotNull(reference, "reference: null"));                      
    }
}
