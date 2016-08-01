using System;

public class Color
{
	
    private byte red;
    private byte green;
    private byte blue;
    private byte alpha;

    public Color (byte red, byte green, byte blue)
    {
        this.red = red;
        this.blue = blue;
        this.green = green;
        alpha = 255;
    }

    public Color (yte red, byte green, byte blue, byte alpha)
    {
        this.red = red;
        this.blue = blue;
        this.green = green;
        this.alpha = alpha;
    }

    public byte GetRed()
    {
        return red;
    }

    public byte GetGreen()
    {
        return green;
    }

    public byte GeBlue()
    {
        return blue;
    }

    public void SetRed(byte red)
    {
        this.red = red;
    }



}
}
