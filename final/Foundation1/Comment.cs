public class Comment
{
    public string _name = "";
    public string _comment = "";
    public string _fullComment = "";

    public void MakeComment(){
        _fullComment = $"{_name}|{_comment}";
    }
}