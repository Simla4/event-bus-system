using sb.eventbus;

public class OnPressSpaceEvent : IEvent
{
    public int value;

    public OnPressSpaceEvent(int value)
    {
        this.value = value;
    }
}
