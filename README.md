# UnityAndroidSensorChecker
Androidのセンサーがどの位電力を消耗しているのか等の確認をするために作成したプロジェクトです。

手っ取り早く実行結果だけ欲しい場合は、SensorChecker.apkを端末に入れて確認してください。

AndroidのSensorクラスから各種情報を出力して確認できるようになっています。<br />
Sensor単位で情報を出しています。Next/Backボタンでページ送り可能です。<br />

## 説明
DefaultAcc: Unityが使用する加速度センサーの名前です。<br />

name:現在情報を出しているセンサーの名前です。<br />
power:センサーの消費電力です。Sensor.getPowerで取得しています。恐らく単位は mA<br />
mode:Sensor.getReportingModeで取得してきた値。0なら継続的にレポート。1なら変化があった時にレポート。
delay:Sensor.getMinDelay() ～ Sensor.getMaxDelay()の値を出しています.


