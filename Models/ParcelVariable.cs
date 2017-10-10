using System;
namespace Parcel.Models
{

  public class ParcelVariable
  {
    private int _length;
    private int _width;
    private int _height;
    private int _weight;

    public string blah;

    public void SetParcel(string newLength, string newWidth, string newHeight, string newWeight)
    {
      if (newLength == "" || newWidth == "" || newHeight == "" || newWeight == "") {
        blah = "You left something blank please try again.";
      }else{
        _length = int.Parse(newLength);
        _width = int.Parse(newWidth);
        _height = int.Parse(newHeight);
        _weight = int.Parse(newWeight);
      }
    }

    public string Alert(){
      return blah;
    }

    public int GetLength()
    {
      return _length;
    }

    public int GetWidth()
    {
      return _width;
    }

    public int GetHeight()
    {
      return _height;
    }

    public int GetWeight()
    {
      return _weight;
    }

    public int GetVolume()
    {
      return _height*_length*_width;
    }

    public int CostToShip()
    {
      return GetVolume()*_weight;
    }
  }
}
