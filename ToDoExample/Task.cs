public class Task
{
    public string Name { get; private set; }
    public string Duration { get; private set; }
    public bool Complete { get; private set; }

    public Task(string myName, string myDuration)
    {
        Name = myName;
        Duration = myDuration;
        Complete = false;
    }

    public void SetName(string theName) => Name = theName;
    public void SetDuration(string theDuration) => Duration = theDuration;
    public void MarkComplete() => Complete = true;
    public void MarkComplete(bool status) => Complete = status;
}   