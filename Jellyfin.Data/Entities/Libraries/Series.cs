#pragma warning disable CA2227

using System;
using System.Collections.Generic;

namespace Jellyfin.Data.Entities.Libraries
{
    /// <summary>
    /// An entity representing a a series.
    /// </summary>
    public class Series : LibraryItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Series"/> class.
        /// </summary>
        public Series()
        {
            DateAdded = DateTime.UtcNow;
            Seasons = new HashSet<Season>();
            SeriesMetadata = new HashSet<SeriesMetadata>();
        }

        /// <summary>
        /// Gets or sets the days of week.
        /// </summary>
        public DayOfWeek? AirsDayOfWeek { get; set; }

        /// <summary>
        /// Gets or sets the time the show airs, ignore the date portion.
        /// </summary>
        public DateTimeOffset? AirsTime { get; set; }

        /// <summary>
        /// Gets or sets the date the series first aired.
        /// </summary>
        public DateTime? FirstAired { get; set; }

        /// <summary>
        /// Gets or sets a collection containing the series metadata.
        /// </summary>
        public virtual ICollection<SeriesMetadata> SeriesMetadata { get; protected set; }

        /// <summary>
        /// Gets or sets a collection containing the seasons.
        /// </summary>
        public virtual ICollection<Season> Seasons { get; protected set; }
    }
}
