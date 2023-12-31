﻿using System.Collections.Generic;
using Technovizz.Objekty;

namespace Technovizz.CodeClass
{
    public class Search
    {
        //Hledání materiálu podle 'Nazev' || 'SAP' pokud najde shodu
        public static Material GetMaterial(string parametr, List<Material> materials)
        {
            foreach (var material in materials)
            {
                if (material.Nazev == parametr || material.SAP == parametr)
                {
                    return material;
                }
            }

            return null;
        }

        public static Project GetPeoject(string parametr, List<Project> projects)
        {
            foreach (var project in projects)
            {
                if (project.TL == parametr || project.Nazev == parametr || project.IMDS == parametr)
                {
                    return project;
                }
            }

            return null;
        }

        public static List<Project> GetProjectContainMaterial(string parameter, List<Project> projects)
        {
            var filteredProjects = new List<Project>();

            foreach (var project in projects)
            {
                if (project.Material.ContainParemeter(parameter))
                {
                    filteredProjects.Add(project);
                }
            }

            return filteredProjects;
        }
    }
}
