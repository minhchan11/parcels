namespace Parcels.Objects
{
  public class ParcelVariables
  {
    public string Length { get; set; }
    public string Width { get; set; }
    public string Weight { get; set; }
    public string Height { get; set; }
    public string Distance { get; set; }

    public string Calculator() {
      int parsedLength = int.Parse(Length);
      int parsedWidth = int.Parse(Width);
      int parsedWeight = int.Parse(Weight);
      int parsedHeight = int.Parse(Height);
      int parsedDistance = int.Parse(Distance);
      int Volume = parsedLength*parsedWidth*parsedHeight;
      return Volume.ToString();
    }
  }
}
