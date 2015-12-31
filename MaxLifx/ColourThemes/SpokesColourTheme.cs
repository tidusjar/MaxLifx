﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxLifx.ColourThemes
{
    public class SpokesColourTheme : IColourTheme
    {
        public new void SetColours(Random r, List<int> hues, List<int> hueRanges, List<double> saturations, List<double> saturationRanges, List<float> brightnesses, List<float> brightnessRanges)
        {
            for (int index = 0; index < hues.Count; index++)
            {
                        hues[index] = r.Next(360); // red
            }

            for (int index = 0; index < hueRanges.Count; index++)
                hueRanges[index] = 0;

            for (int index = 0; index < saturations.Count; index++)
                saturations[index] = .5f;

            for (int index = 0; index < saturationRanges.Count; index++)
                saturationRanges[index] = .5f;

            for (int index = 0; index < brightnesses.Count; index++)
                brightnesses[index] = .5f;

            for (int index = 0; index < brightnessRanges.Count; index++)
                brightnessRanges[index] = .5f;
        }
    }
}
