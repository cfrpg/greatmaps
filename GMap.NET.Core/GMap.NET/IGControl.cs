﻿
namespace GMap.NET
{
   public interface IGControl
   {
      int Zoom
      {
         get;
         set;
      }

      PointLatLng CurrentPosition
      {
         get;
         set;
      }

      Point CurrentPositionGPixel
      {
         get;
      }

      Point CurrentPositionGTile
      {
         get;
      }

      string CacheLocation
      {
         get;
         set;
      }

      long TotalTiles
      {
         get;
      }

      bool IsDragging
      {
         get;
      }

      RectLatLng CurrentViewArea
      {
         get;
      }

      MapType MapType
      {
         get;
         set;
      }

      bool CanDragMap
      {
         get;
         set;
      }

      RenderMode RenderMode
      {
         get;
      }

      // events
      event CurrentPositionChanged OnCurrentPositionChanged;
      event TileLoadComplete OnTileLoadComplete;
      event TileLoadStart OnTileLoadStart;
      event MapDrag OnMapDrag;
      event MapZoomChanged OnMapZoomChanged;

      void ReloadMap();
      void GoToCurrentPosition();

      void SetCurrentPositionOnly(int x, int y);
      void SetCurrentPositionOnly(PointLatLng point);
      bool SetCurrentPositionByKeywords(string keys);

      PointLatLng FromLocalToLatLng(int x, int y);
      Point FromLatLngToLocal(PointLatLng point);

      bool ShowExportDialog();
      bool ShowImportDialog();
   }
}