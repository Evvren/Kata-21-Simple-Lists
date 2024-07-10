namespace SimpleList{

    public class SimpleListService{

            SingleyList? sList = new SingleyList();
             DoublyList? dList = new DoublyList();

        public void Add_S(string? input){
            sList.Add(input);
        }

        public void Delete_S(string? input){
            sList.Delete(input);   
        }

        public string? Find_S(string? input){

                try{
                            return sList.Search(input).Value();
                } catch {
                            return "Error, Value could not be found inside of the string.";
                }

        }

        public string[]? Display_S(){
            return sList.ReturnContent();
        }


        public void Add_D(string? input){
            dList.Add(input);
        }

        public void Delete_D(string? input){
            dList.Delete(input);   
        }

        public string? Find_D(string? input){

                try{
                            return dList.Search(input).Value();
                } catch {
                            return "Error, Value could not be found inside of the string.";
                }

        }

        public string[]? Display_D(){
            return dList.ReturnContent();
        }
    }
}