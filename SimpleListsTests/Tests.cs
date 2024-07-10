using SimpleList;
namespace SimpleListsTests;

public class TestSimpleLists
{
    [Fact]
    public void Test_Simple_Add_Singley()
    {
        SimpleListService service = new SimpleListService();
        service.Add_S("fred");
        Assert.Equal("fred", service.Find_S("fred"));
       
    }

    [Fact]
    public void Test_Multiple_Add_Singley()
    {
        SimpleListService service = new SimpleListService();
        service.Add_S("fred");
        Assert.Equal("fred", service.Find_S("fred"));


        service.Add_S("frod");
        service.Add_S("frid");
        service.Add_S("frud");
        service.Add_S("frad");
        Assert.Equal(["fred","frod","frid","frud","frad"], service.Display_S());
    
    }

    [Fact]
    public void Test_Multiple_Add_With_Search_Singley()
    {
        SimpleListService service = new SimpleListService();
        service.Add_S("fred");
        Assert.Equal("fred", service.Find_S("fred"));


        service.Add_S("frod");
        service.Add_S("frid");
        service.Add_S("frud");
        service.Add_S("frad");
        Assert.Equal(["fred","frod","frid","frud","frad"], service.Display_S());

        Assert.Equal("fred", service.Find_S("fred"));
        Assert.Equal("frod", service.Find_S("frod"));
        Assert.Equal("frid", service.Find_S("frid"));
        Assert.Equal("frud", service.Find_S("frud"));
        Assert.Equal("frad", service.Find_S("frad"));
        Assert.Equal("Error, Value could not be found inside of the string.", service.Find_S("frd"));
    
    }

    [Fact]
    public void Test_Multiple_Add_With_Search_Delete_Singley()
    {
        SimpleListService service = new SimpleListService();
        service.Add_S("fred");
        Assert.Equal("fred", service.Find_S("fred"));


        service.Add_S("frod");
        service.Add_S("frid");
        service.Add_S("frud");
        service.Add_S("frad");
        Assert.Equal(["fred","frod","frid","frud","frad"], service.Display_S());

        Assert.Equal("fred", service.Find_S("fred"));
        Assert.Equal("frod", service.Find_S("frod"));
        Assert.Equal("frid", service.Find_S("frid"));
        Assert.Equal("frud", service.Find_S("frud"));
        Assert.Equal("frad", service.Find_S("frad"));
        Assert.Equal("Error, Value could not be found inside of the string.", service.Find_S("frd"));

        service.Delete_S("frud");
        service.Delete_S("frad");
        Assert.Equal(["fred","frod","frid"], service.Display_S());
        service.Delete_S("fred");
        service.Delete_S("frod");
        Assert.Equal(["frid"], service.Display_S());
        service.Delete_S("frid");
        Assert.Equal([], service.Display_S());
    
    }

    [Fact]
    public void Test_Multiple_Add_With_Search_Delete_Repopulate_Singley()
    {
        SimpleListService service = new SimpleListService();
        service.Add_S("fred");
        Assert.Equal("fred", service.Find_S("fred"));


        service.Add_S("frod");
        service.Add_S("frid");
        service.Add_S("frud");
        service.Add_S("frad");
        Assert.Equal(["fred","frod","frid","frud","frad"], service.Display_S());

        Assert.Equal("fred", service.Find_S("fred"));
        Assert.Equal("frod", service.Find_S("frod"));
        Assert.Equal("frid", service.Find_S("frid"));
        Assert.Equal("frud", service.Find_S("frud"));
        Assert.Equal("frad", service.Find_S("frad"));
        Assert.Equal("Error, Value could not be found inside of the string.", service.Find_S("frd"));

        service.Delete_S("frud");
        service.Delete_S("frad");
        Assert.Equal(["fred","frod","frid"], service.Display_S());
        service.Delete_S("fred");
        service.Delete_S("frod");
        Assert.Equal(["frid"], service.Display_S());
        service.Delete_S("frid");
        Assert.Equal([], service.Display_S());
    
        service.Add_S("fred");
        service.Add_S("frod");
        service.Add_S("frid");
        service.Add_S("frud");
        service.Add_S("frad");
        Assert.Equal(["fred","frod","frid","frud","frad"], service.Display_S());
    }

    [Fact]
    public void Test_Simple_Add_Doubly()
    {
        SimpleListService service = new SimpleListService();
        service.Add_D("fred");
        Assert.Equal("fred", service.Find_D("fred"));
       
    }

    [Fact]
    public void Test_Multiple_Add_Doubly()
    {
        SimpleListService service = new SimpleListService();
        service.Add_D("fred");
        Assert.Equal("fred", service.Find_D("fred"));


        service.Add_D("frod");
        service.Add_D("frid");
        service.Add_D("frud");
        service.Add_D("frad");
        Assert.Equal(["fred","frod","frid","frud","frad"], service.Display_D());
    
    }

    [Fact]
    public void Test_Multiple_Add_With_Search_Doubly()
    {
        SimpleListService service = new SimpleListService();
        service.Add_D("fred");
        Assert.Equal("fred", service.Find_D("fred"));


        service.Add_D("frod");
        service.Add_D("frid");
        service.Add_D("frud");
        service.Add_D("frad");
        Assert.Equal(["fred","frod","frid","frud","frad"], service.Display_D());

        Assert.Equal("fred", service.Find_D("fred"));
        Assert.Equal("frod", service.Find_D("frod"));
        Assert.Equal("frid", service.Find_D("frid"));
        Assert.Equal("frud", service.Find_D("frud"));
        Assert.Equal("frad", service.Find_D("frad"));
        Assert.Equal("Error, Value could not be found inside of the string.", service.Find_D("frd"));
    
    }

    [Fact]
    public void Test_Multiple_Add_With_Search_Delete_Doubly()
    {
        SimpleListService service = new SimpleListService();
        service.Add_D("fred");
        Assert.Equal("fred", service.Find_D("fred"));


        service.Add_D("frod");
        service.Add_D("frid");
        service.Add_D("frud");
        service.Add_D("frad");
        Assert.Equal(["fred","frod","frid","frud","frad"], service.Display_D());

        Assert.Equal("fred", service.Find_D("fred"));
        Assert.Equal("frod", service.Find_D("frod"));
        Assert.Equal("frid", service.Find_D("frid"));
        Assert.Equal("frud", service.Find_D("frud"));
        Assert.Equal("frad", service.Find_D("frad"));
        Assert.Equal("Error, Value could not be found inside of the string.", service.Find_D("frd"));

        service.Delete_D("frud");
        service.Delete_D("frad");
        Assert.Equal(["fred","frod","frid"], service.Display_D());
        service.Delete_D("fred");
        service.Delete_D("frod");
        Assert.Equal(["frid"], service.Display_D());
        service.Delete_D("frid");
        Assert.Equal([], service.Display_D());
    
    }

    [Fact]
    public void Test_Multiple_Add_With_Search_Delete_Repopulate_Doubly()
    {
        SimpleListService service = new SimpleListService();
        service.Add_D("fred");
        Assert.Equal("fred", service.Find_D("fred"));


        service.Add_D("frod");
        service.Add_D("frid");
        service.Add_D("frud");
        service.Add_D("frad");
        Assert.Equal(["fred","frod","frid","frud","frad"], service.Display_D());

        Assert.Equal("fred", service.Find_D("fred"));
        Assert.Equal("frod", service.Find_D("frod"));
        Assert.Equal("frid", service.Find_D("frid"));
        Assert.Equal("frud", service.Find_D("frud"));
        Assert.Equal("frad", service.Find_D("frad"));
        Assert.Equal("Error, Value could not be found inside of the string.", service.Find_D("frd"));

        service.Delete_D("frud");
        service.Delete_D("frad");
        Assert.Equal(["fred","frod","frid"], service.Display_D());
        service.Delete_D("fred");
        service.Delete_D("frod");
        Assert.Equal(["frid"], service.Display_D());
        service.Delete_D("frid");
        Assert.Equal([], service.Display_D());
    
        service.Add_D("fred");
        service.Add_D("frod");
        service.Add_D("frid");
        service.Add_D("frud");
        service.Add_D("frad");
        Assert.Equal(["fred","frod","frid","frud","frad"], service.Display_D());
    }

}