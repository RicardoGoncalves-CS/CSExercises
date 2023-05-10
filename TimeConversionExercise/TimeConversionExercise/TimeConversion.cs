namespace TimeConversionExercise;

// Given a time in 12-hour AM/PM format, convert it to military (24-hour) time. 
public static class TimeConversion
{
    public static string Convert(string s)
    {
        if (s[8] == 'A')
        {
            if (s.Substring(0, 2) == "12")
                return "00" + s.Substring(2, 6);
            else
                return s.Substring(0, 8);
        }

        else
        {
            if (s.Substring(0, 2) == "12")
            {
                return s.Substring(0, 8);
            }
            else
            {
                int hours = int.Parse(s.Substring(0, 2));
                hours += 12;
                return hours.ToString("00") + s.Substring(2, 6);
            }
        }
    }
}
