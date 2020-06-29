using System.Text;

public class TimeSystem
{
    /// <summary>
    /// float시간을 스트링으로 변경 후 리턴
    /// </summary>
    /// <param name="time"></param>
    /// <returns></returns>
    public string GetFloatTimeToStringTime(float time)
    {
        int second = (int)(time % 60f);
        float remainMinute = time / 60f;

        int minute = (int)(remainMinute % 60f);
        float remainHour = remainMinute / 60f;

        int hour = (int)(remainHour % 24f);
        int day = (int)(remainHour / 24f);

        StringBuilder str = new StringBuilder();

        if (day > 0)
        {
            str.Append(day);
            str.Append("일");
        }
        if (hour > 0)
        {
            str.Append(hour);
            str.Append("시");
        }
        if (minute > 0)
        {
            str.Append(minute);
            str.Append("분");
        }

        str.Append(second);
        str.Append("초");

        return str.ToString();
    }
}