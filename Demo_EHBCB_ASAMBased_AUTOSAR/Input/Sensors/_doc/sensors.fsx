<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE MSRSW PUBLIC "-//ASAM//DTD FUNCTIONAL SPECIFICATION EXCHANGE FORMAT:V1.1.0:LAI:IAI:XML:ML.FSX110.DTD//EN" "fsx_v1_1_0.ml.dtd">
<!--FS2FSX Converter Version 1.0 -->
<MSRSW>
	<CATEGORY>FSX</CATEGORY>
	<ADMIN-DATA>
		<LANGUAGE>de</LANGUAGE>
		<USED-LANGUAGES>
			<L-10 L="DE" />
		</USED-LANGUAGES>
	</ADMIN-DATA>
	<SW-SYSTEMS>
		<SW-SYSTEM>
			<SHORT-NAME>MEDC17</SHORT-NAME>
			<LONG-NAME>
				<L-4 L="EN">EDC/ME(D)17</L-4>
			</LONG-NAME>
			<SW-COMPONENT-SPEC>
				<SW-COMPONENTS>
					<SW-FEATURE>
						<SHORT-NAME>Sensor Value Treatment</SHORT-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>
								Overview
							</SHORT-NAME>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Sensors Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Sensors.Main.Sensors</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											Komponentenübersicht der Sensorik der
											Motorsteuerung
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>Komponentenmodule der Sensorik</SHORT-NAME>
							<LONG-NAME>
								<L-4 L="EN">Komponentenmodule der Sensorik</L-4>
							</LONG-NAME>
							<P>
								<L-1 L="DE">
									In den Modulen für die Sensorik werden Rohdaten über
									die Basissoftware-Schnittstellenklassen
									aus Sensoren ausgelesen und durch Rechnung oder über Kennlinien in
									physikalische Größen gewandelt und als Nachrichten für alle
									anderen Module zur Verfügung
									gestellt.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Es werden alle Signale auf Plausibilität geprüft und
									im Fehlerfall ein Fehlerflag gesetzt.
									Außerdem wird überwacht,
									ob der Funktionsaufruf der Basissoftware-Schnittstellenklasse
									erfolgreich ist. Die Fehlerflags der einzelnen
									Komponentenmodule der Sensorik werden
									gesammelt und als
									Nachricht an das Funktionsmodul Operationsmodus
									weitergegeben.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die Funktionen jedes Moduls werden gemäß der
									Taskliste für Bypass-Funktionen aufgerufen
									. Informationen zu
									den jeweils verwendeten Implementierungsdatentypen
									und
									Kennlinien und -feldwerten befinden sich in Anhang I.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Abbildung unten zeigt die Hierarchieebene der
									Sensorik. Der Anschlussbelegung der Komponenten
									an die FlexECU
									wird in Anhang B gezeigt.
								</L-1>
							</P>
							<CHAPTER>
								<SHORT-NAME>Fahrpedal</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="DE">Egas-Steller</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Das Modul Egas-Steller (Egas) erfasst die Position
										des Egas-Stellers. Es werden beide,
										an den Widerständen der
										Potentiometer abfallenden, Spannungen erfasst und über
										experimentell
										bestimmte Kennlinien in Positionen umgerechnet.
										Die Position ergibt sich aus
										dem Mittelwert der beiden
										Einzelpositionen. Es ist möglich, über Egc_flgEgasOverride
										auf
										eine manuelle Positionseingabe durch Egc_facEgasMan
										umzuschalten. Mit dem Flag
										Egc_facEgasFilt kann das Signal
										zusätzlich durch einen Tiefpass gefiltert werden, um
										Sprünge
										und große Änderungsraten zu vermeiden, bevor es als Nachricht
										weitergeben
										wird.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Zur Absicherung gegen Fehler werden die
										Statusinformationen der Klassen zum Auslesen
										der analogen
										Spannungswerte (Egc_stIA1 und Egc_stIA2) herangezogen, eine
										Plausibilitätsprüfung
										auf maximal und minimal mögliche
										Spannungen (Egc_uSensMinValid und
										Egc_uSensMaxValid)
										durchgeführt und auf eine Abweichung der beiden Positionswerte
										von kleiner 5% geprüft. Sobald ein Fehlverhalten auftritt, und
										die Position nicht durch eine
										manuelle Eingabe gesetzt ist,
										wird das Fehlerflag Egc_flgError auf true gesetzt und als
										Nachricht weitergereicht.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Die gesamte Auswertung erfolgt durch die Funktion
										Egc_facEgas_get im 10ms-Raster.
									</L-1>
								</P>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Kühlmitteltemperatur</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Kühlmitteltemperatur</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Das Modul Kühlmitteltemperatur (CoolantTemperature)
										erfasst die Kühlmitteltemperatur
										am Auslass des Motorblocks.
										Bei dem Sensor handelt es sich um ein NTC-Element, dass
										zusammen mit dem internen Pull-up-Widerstand des
										Steuergerätepins einen Spannungsteiler
										mit 5V -Versorgung
										bildet. Die Auswertung berechnet aus der am Sensor abfallenden
										Spannung den Widerstand Ctc_rSens nach Gleichung 5.1 und
										daraus über eine hinterlegte
										Kennlinie die Temperatur
										Ctc_atCool.
									</L-1>
								</P>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>sensors_png_1</SHORT-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>
								<P>
									<L-1 L="DE">
										Um eine gute Auflösung im hohen Temperaturbereich zu
										erhalten, wird ein Pin mit einem
										Pull-up-Widerstand von 1000
										gewählt.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Zur Absicherung gegen Fehler werden die
										Statusinformation der Klasse zum Auslesen des
										analogen
										Spannungswerts Ctc_stIA herangezogen, eine
										Plausibilitätsprüfung auf minimal
										und maximal mögliche
										Spannungen (Ctc_uSensMinValid und Ctc_uSensMaxValid)
										durchgeführt und geprüft, ob die ausgelesene Spannung
										Ctc_uSens kleiner ist als die
										angegebene Referenzspannung der
										Versorgung Ctc_uSupply. Mit der letzten Prüfung wird
										außerdem
										eine Division durch 0 verhindert und gegebenenfalls die
										weitere Auswertung
										nicht durchgeführt. Sobald ein Fehlverhalten
										auftritt, wird das Fehlerflag Ctc_flgError
										auf true gesetzt und
										als Nachricht weitergereicht.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Die gesamte Auswertung erfolgt durch die Funktion
										Ctc_atCool_get im 1000ms-Raster.
									</L-1>
								</P>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Ansauglufttemperatur</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Ansauglufttemperatur</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Das Modul Ansauglufttemperatur (ManifoldTemperature)
										erfasst die Temperatur der
										angesaugten Luft im Saugrohr. Auch
										bei diesem Sensor handelt es sich um ein NTCElement,
										das analog
										zum Kühlmitteltemperatursensor funktioniert.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Um eine gute Auflösung im niedrigen
										Temperaturbereich zu erhalten, wird ein Pin mit
										einem
										Pull-up-Widerstand von 2150 gewählt. Die gesamte Auswertung
										erfolgt durch die
										Funktion Ctc_atCool_get im 20ms-Raster.
									</L-1>
								</P>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Saugrohrdruck</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Saugrohrdruck</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Das Modul Saugrohrdruck (ManifoldPressure) erfasst
										den Druck im Saugrohr. Der Sensor
										wird mit einer 5V -Spannung
										versorgt und liefert einen analogen Spannungswert Mpc_uSens,
										der über eine lineare Kennlinie Mpc_uSens2pManiBase_CUR in den
										Druck umgerechnet wird.
										Zusätzlich wird über die Kennlinie
										Mpc_atManiTmp2facPresCorr_CUR ein Korrekturfaktor,
										je nach
										Ansauglufttemperatur, multiplikativ in die Berechnung
										miteinbezogen.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Zur Absicherung gegen Fehler werden die
										Statusinformation der Klasse zum Auslesen des
										analogen
										Spannungswerts Mpc_stIA herangezogen und eine
										Plausibilitätsprüfung auf minimal
										und maximal mögliche
										Spannungen (Mpc_uSensMinValid und Mpc_uSensMaxValid)
										durchgeführt. Sobald ein Fehlverhalten auftritt, wird das
										Fehlerflag Mpc_flgError auf true
										gesetzt und als Nachricht
										weitergereicht.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Aufgrund von Pulsationseffekten im Saugrohr durch die
										Absaugung in die einzelnen
										Zylinder wird ein gemittelter
										Saugrohrdruck zur weiteren Verarbeitung verwendet. Dazu
										wird,
										solange kein Fehler vorliegt und der Motor sich dreht
										(Drehzahl größer 30 1
										min),
										im 1ms-Raster in der Funktion
										Mpc_pMani_get der Saugrohrdruck erfasst und in einem
										Akkumulator aufsummiert, während gleichzeitig die Anzahl
										erfasster Werte in einem Zähler
										mitgezählt wird. Zur
										Darstellung der Pulsationseffekte wird der ausgelesene Druck
										ohne
										Mittelwertsbildung als Nachricht
										<TT TYPE="PRM">Mpc_pMani</TT>
										zur Verfügung gestellt.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Im Synchron-Raster werden dann in der Funktion
										Mpc_pMani_calc der Mittelwert durch
										Division der aufsummierten
										Druckwerte durch die Anzahl gebildet, in Mpc_pManiFilt zur
										Verfügung gestellt und sowohl Akkumulator als auch Zähler
										zurückgesetzt. Der Synchron-
										Interrupt wird für jeden Zylinder
										alle zwei Umdrehungen, also einmal pro Arbeitsspiel
										ausgelöst,
										d.h., bei jeder Mittelwertsberechnung des Saugrohrdrucks wird
										sichergestellt, dass
										sich die Kurbelwelle um genau den gleichen
										Winkel gedreht hat seit der vorangegangenen
										Berechnung, nämlich
										240°KW. Dadurch ist sichergestellt, dass bei jeder Auswertung
										die
										gleichen Konditionen vorliegen. Zusätzlich wird durch
										Prüfung des Zählers auf Null eine
										Division durch Null
										verhindert.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Das Aufsummieren des Akkumulators und Inkrementieren
										des Zählers wird als atomarer Rechenschritt
										ausgeführt
										(Kennzeichnung Beginn durch ^, Ende durch v), um zu
										verhindern,
										dass der Synchron-Interrupt dazwischen aufgerufen
										wird. Gleiches gilt für das Rücksetzen
										der Zähler, auch wenn
										hier die Notwendigkeit nicht gegeben ist, da der
										Synchron-Interrupt
										präemptiv ausgeführt wird (s. auch Abschnitt
										2.4).
									</L-1>
								</P>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Batteriespannung</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Batteriespannung</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Das Modul Batteriespannung (BatteryVoltage) erfasst
										die Batteriespannung über einen
										Spannungsteiler. Dabei wird der
										Bereich der Batteriespannung, durch entsprechende Wahl
										der
										Widerstände des Spannungsteilers, von rund 0 - 21V auf den
										Messbereich eines
										Analogeingangs des Steuergeräts von 0 - 5V
										abgebildet.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Der ausgelesene Wert Bvc_uSens wird nach Gleichung
										5.2 in die Batteriespannung zurückgerechnet
										und in Bvc_uBatt
										als Nachricht zur Verfügung gestellt.
									</L-1>
								</P>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>sensors_png_2</SHORT-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>
								<P>
									<L-1 L="DE">
										Zur Absicherung gegen Fehler werden die
										Statusinformation der Klasse zum Auslesen
										des analogen
										Spannungswerts (Bvc_stIA herangezogen und eine
										Plausibilitätsprüfung auf
										maximal und minimal sinnvolle
										Spannungen (Bvc_uBattMin und Bvc_uBattMax) durchgeführt.
										Sobald ein Fehlverhalten auftritt, wird das Fehlerflag
										Bvc_flgError auf true gesetzt
										und als Nachricht weitergereicht.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Die gesamte Auswertung erfolgt durch die Funktion
										Bvc_uBatt_get im 10ms-Raster.
									</L-1>
								</P>
								<NOTE NOTE-TYPE="HINT">
									<P>
										<L-1 L="DE">
											Das Komponentenmodul Batteriespannung ist
											notwendig, da in der aktuellen
											Version der Basissoftware die
											Batteriespannung noch nicht richtig ausgelesen
											und in der
											Variablen BattU_u zur Verfügung gestellt wird. Sie beinhaltet
											immer
											0V . Sobald das behoben ist, wird das Modul nicht weiter
											benötigt.
										</L-1>
									</P>
								</NOTE>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Öldruck</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Öldruck</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Das Modul Öldruck (OilPressure) stellt fest, ob bei
										drehendem Motor der Öldruck aufgebaut
										wird. Der Sensor ist ein
										Schalter, der bei fehlendem Öldruck den Anschluss auf Masse
										zieht. Die Funktion Opc_pOil_get wird im 10ms-Raster
										ausgeführt und gibt den Zustand
										Opc_stSens des Sensors zurück.
										Sobald die Statusinformation der Klasse zum Auslesen
										des
										Digitalwerts negativ ist oder bei einer Drehzahl größer
										Opc_rpmEngMinOilPressure
										kein Öldruck vorhanden ist, wird das
										Fehlerflag Opc_flgError auf true gesetzt und als
										Nachricht
										weitergereicht.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Zusätzlich steht der aktuelle Zustand in der
										Nachricht Opc_stOilPressure zur Verfügung.
									</L-1>
								</P>
							</CHAPTER>
						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>
