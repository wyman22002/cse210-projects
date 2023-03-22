public class Video
{
    public string _title = "";
    public string _author = "";
    public int _length = 0;
    public List<string> _comments = new List<string>();

    public void Display(){
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"{_length} seconds long.");
        Console.WriteLine();
        Console.WriteLine($"Number of comments: {_comments.Count}");
        Console.WriteLine("Comments:");
        foreach (string item in _comments){
            string[] commentArray = item.Split('|');
            string name = commentArray[0];
            string comment = commentArray[1];
            Console.WriteLine($"Username: {name}");
            Console.WriteLine($"Comment: {comment}");
            Console.WriteLine();
        }
        

    }
}