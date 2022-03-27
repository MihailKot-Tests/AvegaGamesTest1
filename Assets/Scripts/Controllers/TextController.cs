using UnityEngine.UI;


namespace AvegaGamesTest1
{
    public sealed class TextController
    {
        private Text _textAmmo;
        private Text _textHP;

        private Text _textRed;
        private Text _textYellow;
        private Text _textGreen;

        public TextController(Text textAmmo, Text textHP, Text textRed, Text textYellow, Text textGreen)
        {
            _textAmmo = textAmmo;
            _textHP = textHP;

            _textRed = textRed;
            _textYellow = textYellow;
            _textGreen = textGreen;
        }

        public void SetAmmoText(int ammo)
        {
            _textAmmo.text = $"AMMO: {ammo.ToString()}";
        }

        public void SetHPText(int hp)
        {
            _textHP.text = $"HP: {hp}";
        }

        public void ChangeCountColor(int countRed, int countYellow, int countGreen)
        {
            _textRed.text = $"RED: {countRed.ToString()}";
            _textYellow.text = $"RED: {countYellow.ToString()}";
            _textGreen.text = $"RED: {countGreen.ToString()}";
        }
    }
}