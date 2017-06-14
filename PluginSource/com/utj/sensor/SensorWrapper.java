package com.utj.sensor;

import com.unity3d.player.*;
import android.content.Context;
import android.hardware.SensorManager;
import android.hardware.Sensor;
import android.hardware.SensorManager;
import java.util.List;

public class SensorWrapper
{
  private static Sensor mAccelerometer;
  private static List<Sensor> mSensors;
  private static String defaultAccSensor;

  
  public static void init(){
    SensorManager mgr = (SensorManager)UnityPlayer.currentActivity.getSystemService(Context.SENSOR_SERVICE);
    mSensors = mgr.getSensorList(Sensor.TYPE_ALL );
    defaultAccSensor = mgr.getDefaultSensor( Sensor.TYPE_ACCELEROMETER ).getName();
  }

  public static String getDefaultAccSensor(){
    return defaultAccSensor;
  }

  public static int getSensorCount(){
    return mSensors.size();
  }

  public static String getSensorName(int idx){
    return mSensors.get(idx).getName();
  }
  

  public static float getPower(int idx){
    return mSensors.get(idx).getPower();
  }
  public static int getReportingMode(int idx){
    return mSensors.get(idx).getReportingMode();
  }

  
  public static int getMinDelay(int idx){
    return mSensors.get(idx).getMinDelay();
  }
  public static int getMaxDelay(int idx){
    return mSensors.get(idx).getMaxDelay() ;
  }
  public static boolean isWakeUpSensor(int idx) {
    return  mSensors.get(idx).isWakeUpSensor();
  }
}
