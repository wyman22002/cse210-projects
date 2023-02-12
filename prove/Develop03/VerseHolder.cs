public class VerseHolder
{

    public string _VerseHeading = "3 Nephi 11:25";
    public string _VerseOriginal = "Having authority given me of Jesus Christ, I baptize you in the name of the Father, and of the Son, and of the Holy Ghost. Amen.";
    public string _Verse = "Having authority given me of Jesus Christ, I baptize you in the name of the Father, and of the Son, and of the Holy Ghost. Amen.";

    public string VerseCompilier() {
        string _VerseCompleate = _VerseHeading + " " + _Verse;
        return _VerseCompleate;
    }


    public VerseHolder(){
        
    }
}