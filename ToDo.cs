namespace knightmoves;
public class ToDo
{
    // Add your code here
    public string[] MarkAsDone(string[] todos){
        int index = 0;

        while(index < todos.Length){
            todos[index] = "done - " + todos[index];
            index++;
        }

            return todos;
    }
}
