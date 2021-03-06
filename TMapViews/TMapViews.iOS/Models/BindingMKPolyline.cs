﻿using CoreLocation;
using MapKit;
using TMapViews.Models;

namespace TMapViews.iOS.Models
{
    public class BindingMKPolyline : MKPolyline, IBindingMKMapOverlay
    {
        private MKMapRect _boundingMapRect;
        private CLLocationCoordinate2D _coordinate;

        public IBindingMapAnnotation Annotation { get; set; }

        public override MKMapRect BoundingMapRect => _boundingMapRect;
        public override CLLocationCoordinate2D Coordinate => _coordinate;

        public MKOverlayRenderer Renderer { get; set; }

        private BindingMKPolyline(MKPolyline polyline)
        {
            _boundingMapRect = polyline.BoundingMapRect;
            _coordinate = polyline.Coordinate;
        }

        public new static BindingMKPolyline FromCoordinates(CLLocationCoordinate2D[] coords)
            => new BindingMKPolyline(MKPolyline.FromCoordinates(coords));

        public new static BindingMKPolyline FromPoints(MKMapPoint[] points)
            => new BindingMKPolyline(MKPolyline.FromPoints(points));
    }
}