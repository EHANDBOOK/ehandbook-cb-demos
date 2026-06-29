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
						<SHORT-NAME>Torque Structure</SHORT-NAME>
						<LONG-NAME>
							<L-4 L="EN">Torque Structure</L-4>
						</LONG-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>Overview</SHORT-NAME>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Tqs Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>TorqueStructure.Main</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
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
							<SHORT-NAME>Momentenstruktur</SHORT-NAME>	
							<P>
								<L-1 L="DE">
									Das Modul Momentenstruktur (TorqueStructure) berechnet das
									benötigte Moment, dass der
									Motor bereitstellen muss, um sich
									selbst am laufen zu halten und dem Fahrerwunsch gerecht
									zu
									werden. Zur Selbsterhaltung muss der Motor soviel Moment
									abgeben, wie durch innere
									Verluste verbraucht wird
									(Schleppmoment
									<TT TYPE="VARIABLE">Tqs_tqDrag</TT>
									). Es wird in Abhängigkeit von der
									Drehzahl
									<TT TYPE="VARIABLE">Epm_rpmEngSpd</TT>
									und der relativen Füllung
									<TT TYPE="VARIABLE">Amf_facRelAir</TT>
									über das Kennfeld
									<TT TYPE="PRM">Tqs_rpmEngSpdfacRelAir2tqDrag_MAP</TT>
									abgeschätzt. Grundsätzlich kann man sagen, dass
									bei hohen
									Drehzahlen mehr Reibung, welche zu größerem Schleppmoment
									führt, auftritt als
									bei Niedrigen. Hinzu kommt eine Korrektur
									durch die Kühlmitteltemperatur
									<TT TYPE="VARIABLE">Ctc_atCool</TT>
									über das Kennfeld
									<TT TYPE="PRM">Tqs_atCool2tqDrag_CUR</TT>
									. Bei sehr niedrigen Temperaturen erhöht sich
									das Schleppmoment
									durch die hohe Viskosität des Motoröls. Ab einer Temperatur von
									rund 60 degree Celsius wird es zu Null.
								</L-1>
							</P>

							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>TorqueStructure.Main.EngSpdControl</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											EngSpdControl
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="JPG" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>


							<P>
								<L-1 L="DE">
									Der Motor soll ohne Fahrerwunsch stabil eine
									Leelaufdrehzahl halten, d. h., die Momentenanforderung
									muss dem
									Schleppmoment entsprechen. Bei hohen Drehzahlen soll die
									Momentenanforderung ohne Fahrerwunschmoment zurückgehen, damit
									sich die Drehzahl
									reduziert (Motorbremse) und bei niedrigeren
									als der Leerlaufdrehzahl erhöhen, damit der
									Motor nicht ausgeht.
									Das wird erreicht, indem ein drehzahlabhängiges minimales
									Moment
									errechnet wird. Dazu wird der Stabilisierungsfaktor
									Tqs_facEngSpdStab durch Division der
									Leerlaufdrehzahl
									Tqs_rpmTorqueInc und der aktuellen Drehzahl errechnet und mit
									dem
									Schleppmoment multipliziert. Bei hohen Drehzahlen ist das
									minimal angeforderte Moment
									kleiner als das Schleppmoment, der
									Motor bremst also, bei Leerlaufdrehzahl wird der Faktor
									zu Eins,
									d. h., das Schleppmoment wird genau ausgeglichen und bei
									Drehzahlen unterhalb
									der Leerlaufdrehzahl findet eine Überhöhung
									statt, sodass der Motor beschleunigt und
									versucht die
									Leerlaufdrehzahl zu erreichen. Die Bildung aus dem Maximum von
									Drehzahl
									und Eins dient dazu, unter allen Umständen eine
									Division durch Null zu verhindern.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Auf Basis dessen wird im Anschluss der Fahrerwunsch abhängig
									von Drehzahl und Pedalstellung
									<TT TYPE="VARIABLE">Egc_facEgas</TT>
									über das Kennfeld
									<TT TYPE="PRM">Tqs_rpmEngSpdfacEgas2facEgasFilt_MAP</TT>
									gefiltert
									und als Faktor zwischen dem minimal benötigten und dem ebenfalls
									drehzahlabhängigen
									(
									<TT TYPE="PRM">Tqs_rpmEngSpd2tqMax_CUR</TT>
									) maximal abgebbaren Moment
									<TT TYPE="VARIABLE">Tqs_tqMax</TT>
									interpretiert. Abbildung
									5.7 veranschaulicht die Zusammenhänge der Berechnungen (s. auch
									Gleichung 5.12)
									grafisch.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die Grundparametrierung der Kennfeld- und Kennlinienwerte stammen
									aus einem vorhandenen
									BMW-8-Zylinder-Modell mit entsprechenden Anpassungen (in der Regel Multiplikation
									mit Faktor 38).
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>tqs_png_1</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="PNG" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
							<P>
								<L-1 L="DE">
									Zusätzlich zu der beschriebenen Implementierung kommt
									noch ein Drehzahlregler. Es
									handelt sich dabei um einen
									PI-Regler, der die Regelabweichung zwischen Solldrehzahl
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>tqs_png_2</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											Aufbau der Momentenstruktur
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="PNG" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
							<P>
								<L-1 L="DE">
									<TT TYPE="PRM">Tqs_rpmEngSpdIdle</TT>
									und Ist-Drehzahl als Eingangsgröße bekommt und das Moment
									<TT TYPE="VARIABLE">Tqs_tqIdleSpdCtrlCorr</TT>
									zur Korrektur ausgibt. Für die Implementierung wird der in
									Abschnitt 3.9 beschriebene PID-Regler verwendet, dessen
									D-Anteil, durch TV = 0.0 ausgeschaltet
									wird. Durch das Flag
									<TT TYPE="PRM">Tqs_flgIdleSpdCtrlEnable</TT>
									kann der Regler ein- und ausgeschaltet
									werden, wenn die Egas-Steller-Position unter 5% ist, also kein
									Fahrerwunsch besteht.
									Die Begrenzung der Stellgröße erfolgt asymmetrisch nach oben (
									<TT TYPE="PRM">Tqs_tqIdleSpdCtrlMax</TT>
									=
									80Nm) und unten (
									<TT TYPE="PRM">Tqs_tqIdleSpdCtrlMin</TT>
									= -10Nm). Damit wird erreicht das der
									Regler ausreichend Spielraum hat den Motor zu beschleunigen, ihn aber
									nicht zu schnell
									abbremsen kann, was ohne weitere Maßnahmen zu einem weicheren Abfangen
									bei fallenden
									Drehzahlen führt.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die Reglerauslegung erfolgt nach dem Verfahren der
									experimentellen Reglereinstellung
									nach Ziegler-Nichols. Der I-Anteil des Reglers kann durch setzen
									der Nachstellzeit auf einen
									großen Wert (z. B.
									<TT TYPE="PRM">Tqs_tiTnIdleSpdCtrl</TT>
									= 106) quasi ausgeschaltet werden.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Zur Vereinfachung wird hierbei keine drehzahlabhängige
									Verstärkung verwendet, sondern
									der schlechteste Fall, der sich bei niedrigen Drehzahlen befindet.
									Die kritische Verstärkung
									liegt bei rund KPkrit = 0,065, woraus sich eine Reglerverstärkung
									<TT TYPE="PRM">Tqs_facKIdleSpdCtrl</TT>
									=
									0,4 × KPkrit = 0,026 ergibt. Die kritische Frequenz bzw.
									Periodendauer ergibt sich nach
									Abbildung 5.8 aus dem Mittelwert von 10 Schwingungen zu TKrit = 8,96/10
									sek = 0,9sek. Damit
									ist Tn = 0,8×TKrit = 0,72sek. Abbildung 5.9 zeigt die
									Sprungantwort des drehzahlgeregelten
									Systems. [16]
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>tqs_png_3</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											Kritische Frequenz der Drehzahlreglerauslegung
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="PNG" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
							<P>
								<L-1 L="DE">
									Durch das Flag
									<TT TYPE="PRM">Tqs_flgTorqueReqOverride</TT>
									kann die Momentenanforderung manuell
									mit
									<TT TYPE="PRM">Tqs_tqReqMan</TT>
									überschrieben werden, bevor sie als Nachricht weitergereicht
									wird. Die
									Auswertung der Funktion Tqs_calc erfolgt im 20ms-Raster.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die Idee, die Momentenstruktur in dieser Art umzusetzen, entstammt
									dem Skript „Engine
									Control Systems“ von Georg Mallebrein. [17]
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>tqs_png_4</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											Sprungantwort des Drehzahlreglers
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="PNG" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
							<NOTE NOTE-TYPE="HINT">
								<P>
									<L-1 L="DE">Die Auslegung erfolgt in der Simulation gegen
										LABCAR. Eventuell muss eine
										Anpassung am Motor durchgeführt werden.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">Bei der Auslegung des Saugrohrdruckreglers muss
										berücksichtigt werden, dass
										im Modul Drosselklappe (s. auch Abschnitt 5.5.1) eine
										Positionsregelung der
										Drosselklappe erfolgt. Es handelt sich um eine Regler-Kaskade, d. h.,
										Änderungen
										am Regler für die Drosselklappenposition können Auswirkungen auf
										die
										Saugrohrdruckregelung haben.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">Zunächst wird der Motor nur als Saugmotor betrieben,
										d. h., das Wastegate ist
										immer voll geöffnet. Weiterhin findet nie ein Vollastbetrieb statt.
										Es stellt sich
										kein oder nur ein geringer Ladedruck ein, wodurch der
										Wastegateregler nie in
										Betrieb war und die Reglerparameter nicht eingestellt sind.
									</L-1>
								</P>
							</NOTE>


						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>