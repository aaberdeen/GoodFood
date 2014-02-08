using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;


namespace Good_Food_Database
{
    class Recipe
    {

       

        private int _recipe_id;
        private string _recipe_name;
        private int _page_number;
        private string _author;
        private int _source_id;
        private string _issue;
        private int _section_id;
        private string _comments;
        private int _rating;
        public RecipeCardControl recipeCard;
       // private DataTable _Mags;

        public Recipe(DataTable Source,DataTable Sections, SQLITE db)
        {
            recipeCard = new RecipeCardControl(Source,Sections, db);
        }



        public int recipe_id
        {
            get { return _recipe_id; }
            set { _recipe_id = value; }
        }

        public string recipe_name
        {
            get { return _recipe_name; }
            set { _recipe_name = value; }
        }


        public int page_number
        {
            get { return _page_number; }
            set { _page_number = value; }
        }
        
        public string author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int source_id
        {
            get { return _source_id; }
            set { _source_id = value; }
        }
        public string issue
        {
            get { return _issue; }
            set { _issue = value; }
        }
        public int section_id
        {
            get { return _section_id; }
            set { _section_id = value; }
        }
        public string comments
        {
            get { return _comments; }
            set { _comments = value; }
        }
        public int rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
            
        
    }
}
