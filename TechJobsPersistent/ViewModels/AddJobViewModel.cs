using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Skills { get; set; }

        public int SkillId { get; set; }
        public List<SelectListItem> Employers { get; set; }

        public AddJobViewModel(List<Employer> list,List<Skill> skills)
        {
            Employers = new List<SelectListItem>();
            foreach (var employer in list)
            {
                Employers.Add(new SelectListItem
                                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
            Skills = new List<SelectListItem>();
            foreach(Skill skill in skills)
            {
                Skills.Add(new SelectListItem
                {
                    Value = skill.Id.ToString(),
                    Text = skill.Name
                });

                }
        }

        public AddJobViewModel(){}
    }
}
       




