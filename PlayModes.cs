namespace Oksana_Cherkas_Lr_1;

public class PlayModes
{
    public BasePlay Play()
    {
        return new Play();
    }
    public BasePlay WinOnly()
    {
        return new WinOnly();
    }
    public BasePlay LoseOnly()
    {
        return new LoseOnly();
    }
    public BasePlay NoRating()
    {
        return new NoRating();
    }
}