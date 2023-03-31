public class Comment
{
    public string _name = "";
    public string _comment = "";
    public string _fullComment = "";

    public Comment(string name, string comment){
        _name = name;
        _comment = comment;
    }

    public void MakeComment(){
        _fullComment = $"{_name}|{_comment}";
    }
}