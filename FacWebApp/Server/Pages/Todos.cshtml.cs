using Microsoft.AspNetCore.Mvc.RazorPages;

public class TodosPageModel : PageModel {
    public List<String> TodoItems { get;set;}
    public TodosPageModel(IProvideTodoLists listProvider) {
        TodoItems = listProvider.GetTodoList();
    }
}