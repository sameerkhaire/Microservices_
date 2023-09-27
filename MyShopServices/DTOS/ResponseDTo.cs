namespace MyShopServices.DTOS
{
    public class ResponseDTo
    {

        public bool Success { get; set; } = true;
        public string DisplayMessage { get; set; } = "";
        public object Result { get; set; }
        public List<string> ErrorMessage { get; set; }
        public ResponseDTo()
        {

        }
    }
}
