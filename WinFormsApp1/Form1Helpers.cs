/// <summary>
/// Class with methodes to help form's elements and events with routine tasks:
/// 1) DoubleFromText
/// </summary>
internal class Form1Helpers
{
    /// <summary>
    /// Methode for creating double-type numbers  from text with decimal comma and/or with decimal dot.
    /// It does NOT validate if the text is convertible to number!
    /// </summary>
    /// <param name="text">Text from textBox filled in by user.</param>
    /// <returns> double-type number </returns>
    internal double DoubleFromText(string text)
    {
        //sender.text can contain decimal coma instead of decimal dot, based on cultural 
        if (text.Contains(','))
        {
            text = text.Replace(',', '.');
        }
        return double.Parse(text);
    }
}