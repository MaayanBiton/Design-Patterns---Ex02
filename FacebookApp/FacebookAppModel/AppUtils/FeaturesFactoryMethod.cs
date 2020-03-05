using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp
{
    public class FeaturesFactoryMethod
    {
        public static IFeature Create(MethodFactoryTypes.eFacebookFeatureType i_FeatureName, UserProxy i_LoggedInUser)
        {
            if (i_FeatureName.Equals(MethodFactoryTypes.eFacebookFeatureType.LikeSorter))
            {
                return new LikeSorter(i_LoggedInUser);
            }
            else if (i_FeatureName.Equals(MethodFactoryTypes.eFacebookFeatureType.MatchFinder))
            {
                return new MatchFinder(i_LoggedInUser);
            }
            else 
            {
                return new PostNewStatus(i_LoggedInUser);
            }
        }
    }
}