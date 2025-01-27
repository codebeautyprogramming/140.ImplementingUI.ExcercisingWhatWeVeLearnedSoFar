﻿using DataAccessLayer.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{
    public partial class RecipeIngredientsForm : Form
    {
        private readonly IRecipeIngredientsRepository _recipeIngredientsRepository;
        private readonly IIngredientsRepository _ingredientsRepository;
        public RecipeIngredientsForm(IRecipeIngredientsRepository recipeIngredientsReposiotry, IIngredientsRepository ingredientsRepository)
        {
            InitializeComponent();
            _recipeIngredientsRepository = recipeIngredientsReposiotry;
            _ingredientsRepository=ingredientsRepository;
        }
    }
}
