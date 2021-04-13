using DataUtilities.ViewModel;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace DataUtilities.Repository
{
    public class Repository_Recipe
    {
        public Repository_Recipe() { }


        //building all recipes, in this section use possible connection with Entity Framwork
        // or add connection to databases for retriving data and fit data into the right pre-design C# model.
        public List<Model_Recipe> getAllRecipes() {
            //to semplify I created manually those models
            return this.creatingRecipes();
        }

        public List<Model_Step> getStepsFromId(int id) {

            if (id < 0) { return null; }

            return getAllRecipes().Find(x => x.id == id).steps;

        }

        private List<Model_Recipe> creatingRecipes() {
    
            Model_Recipe LemonTea = new Model_Recipe
            {

                id = 0,
                name = "Lemon Tea",
                steps = new List<Model_Step> {
                    new Model_Step{
                        id=0,
                        stepNo=1,
                        description="Boil some water"
                    },
                    new Model_Step{
                        id=1,
                        stepNo=2,
                        description="Steep the water in the cup",
                    },
                        new Model_Step{
                        id=2,
                        stepNo=3,
                        description="Pour tea in the cup"
                    },
                    new Model_Step{
                        id=3,
                        stepNo=4,
                        description="Add lemon",

                    }
                }
            };

            Model_Recipe Coffee = new Model_Recipe
            {
                id = 1,
                name = "Coffee",
                steps = new List<Model_Step> {
                    new Model_Step{
                        id=0,
                        stepNo=1,
                        description="Boil some water"
                    },
                    new Model_Step{
                        id=1,
                        stepNo=2,
                        description="Brew the cofee ground",
                    },
                     new Model_Step{
                        id=2,
                        stepNo=3,
                        description="Pour tea in the cup"
                    },
                    new Model_Step{
                        id=3,
                        stepNo=4,
                        description="Add sugar and milk",

                    }
                }

            };

            Model_Recipe Chocolate = new Model_Recipe
            {
                id = 2,
                name = "Chocolate",
                steps = new List<Model_Step> {
                    new Model_Step{
                        id=0,
                        stepNo=1,
                        description="Boil some water"
                    },
                    new Model_Step{
                        id=1,
                        stepNo=2,
                        description="Add drinking chocolate powder to the water",
                    },
                     new Model_Step{
                        id=2,
                        stepNo=3,
                        description="Pour chocolate in the cup"
                    }
                }
            };

            return new List<Model_Recipe> { 
                LemonTea,
                Coffee,
                Chocolate
            };





        }
    }


}
