class win{
    public bool victory(List<string> emptyWord)
    {
        if (emptyWord.Contains("_ "))
        {
            return false;
        }
        else
        {
            return true;
        }

    }
}