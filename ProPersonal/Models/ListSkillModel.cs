using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ProPersonal.Models
{
    /// <summary>
    /// The model to return the value of selected itrem in the list of skills
    /// </summary>
    public class ListSkillModel
    {
        public List<Skill> listedSkills;

        public SelectList Skill { get; set; }

        public string SelectedSkill { get; set; }
    }
}

