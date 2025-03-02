namespace MVC_MyFirstMVCProject.Models
{
    public class Item
    {// This class represents the data of our app
        // Will be a table in a database and each
        // Each property in this class will reprenet a collumn in the database
        public int Id { get; set; } // make the property accessebly outside the class
        public string Name { get; set; }
        // We want to make it accesseble from /items/overview
        // Therefore, we shoud create a controller
    
    }
}
