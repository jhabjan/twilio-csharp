/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Video.V1.Room.Participant 
{

    /// <summary>
    /// Returns a single Track resource represented by `TrackNameOrSid`.
    /// </summary>
    public class FetchPublishedTrackOptions : IOptions<PublishedTrackResource> 
    {
        /// <summary>
        /// Unique Room identifier where this Track is published.
        /// </summary>
        public string PathRoomSid { get; }
        /// <summary>
        /// Unique Participant identifier that publishes this Track.
        /// </summary>
        public string PathParticipantSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchPublishedTrackOptions
        /// </summary>
        /// <param name="pathRoomSid"> Unique Room identifier where this Track is published. </param>
        /// <param name="pathParticipantSid"> Unique Participant identifier that publishes this Track. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public FetchPublishedTrackOptions(string pathRoomSid, string pathParticipantSid, string pathSid)
        {
            PathRoomSid = pathRoomSid;
            PathParticipantSid = pathParticipantSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Returns a list of tracks associated with a given Participant. Only `currently` Published Tracks are in the list
    /// resource.
    /// </summary>
    public class ReadPublishedTrackOptions : ReadOptions<PublishedTrackResource> 
    {
        /// <summary>
        /// Unique Room identifier where this Track is published.
        /// </summary>
        public string PathRoomSid { get; }
        /// <summary>
        /// Unique Participant identifier that publishes this Track.
        /// </summary>
        public string PathParticipantSid { get; }

        /// <summary>
        /// Construct a new ReadPublishedTrackOptions
        /// </summary>
        /// <param name="pathRoomSid"> Unique Room identifier where this Track is published. </param>
        /// <param name="pathParticipantSid"> Unique Participant identifier that publishes this Track. </param>
        public ReadPublishedTrackOptions(string pathRoomSid, string pathParticipantSid)
        {
            PathRoomSid = pathRoomSid;
            PathParticipantSid = pathParticipantSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}