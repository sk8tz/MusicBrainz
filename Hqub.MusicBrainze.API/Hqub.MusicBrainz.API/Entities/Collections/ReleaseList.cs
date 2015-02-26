﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hqub.MusicBrainz.API.Entities.Collections
{
    [XmlRoot("release-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class ReleaseList : BaseList
    {
        [XmlElement("release")]
        public List<Release> Items { get; set; }
    }
}