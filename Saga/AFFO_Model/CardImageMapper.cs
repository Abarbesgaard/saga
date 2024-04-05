using Debugger = Debugland.Debugger;

namespace Saga.Model
{
    public class CardImageMapper
    {
        // Method to get the image path for a given card
        public string GetImageForCard(string cardName)
        {
            Debugger.MethodInitiated("GetImageForCard");

            string imageName = cardName.Replace(" ", ""); // Remove spaces from card name


            Debugger.Variable("imageName", $"{imageName}");

            string imagePath = $"/Image/{imageName}.png"; // Assuming image filenames follow the format "{CardName}.png"


            Debugger.MethodTerminated("GetImageForCard");
            return imagePath;
        }
    }
}

