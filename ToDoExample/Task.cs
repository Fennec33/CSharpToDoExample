namespace ToDoExample;
public class Task
{
    public string Name { get; private set; }
    public string Duration { get; private set; }
    public bool Complete { get; private set; }

    public Task(string name, string duration)
    {
        Name = name;
        Duration = duration;
        Complete = false;
    }

    public Task(string name, string duration, bool complete)
    {
        Name = name;
        Duration = duration;
        Complete = complete;
    }

    public override string ToString()
    {
        return $"{Name},{Duration},{Complete}";
    }

    public void SetName(string theName) => Name = theName;
    public void SetDuration(string theDuration) => Duration = theDuration;
    public void MarkComplete() => Complete = true;
    public void MarkComplete(bool status) => Complete = status;
}   