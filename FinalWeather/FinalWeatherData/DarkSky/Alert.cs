using System;
using System.Collections.Generic;

namespace FinalWeatherData.DarkSky
{
    public class Alert
    {
        public Alert()
        {
            
        }

        /// <summary>
        /// required
        /// A detailed description of the alert.
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// required
        /// The UNIX time at which the alert will expire.
        /// </summary>
        public string Expires { get; set; }
        
        /// <summary>
        /// required
        /// An array of strings representing the names of the regions covered by this weather alert.
        /// </summary>
        public List<string> Regions { get; set; }
    
        /// <summary>
        /// required
        /// The severity of the weather alert. Will take one of the following values: "advisory" (an individual should be aware of potentially severe weather), "watch" (an individual should prepare for potentially severe weather), or "warning" (an individual should take immediate action to protect themselves and others from potentially severe weather).
        /// </summary>
        public string Severity { get; set; }
        
        /// <summary>
        /// required
        /// The UNIX time at which the alert was issued.
        /// </summary>
        public string Time { get; set; }
    
        /// <summary>
        /// required
        /// A brief description of the alert.
        /// </summary>
        public string Title { get; set; }
    
        /// <summary>
        /// required
        /// An HTTP(S) URI that one may refer to for detailed information about the alert.
        /// </summary>
        public string Uri { get; set; }
            
    }
}
