<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE MSRSW PUBLIC "-//ASAM//DTD FUNCTIONAL SPECIFICATION EXCHANGE FORMAT:V1.1.0:LAI:IAI:XML:ML.FSX110.DTD//EN" "c:/dtd/fsx_v1_1_0.ml.dtd">
<MSRSW>
	<CATEGORY>FSX</CATEGORY>
	<ADMIN-DATA>
		<LANGUAGE>en</LANGUAGE>
		<USED-LANGUAGES>
			<L-10 L="EN" />
			<L-10 L="EN" />
		</USED-LANGUAGES>
	</ADMIN-DATA>
	<SW-SYSTEMS>
		<SW-SYSTEM>
			<SHORT-NAME>MEDC17</SHORT-NAME>
			<LONG-NAME>
				<L-4 L="EN" />
			</LONG-NAME>
			<SW-COMPONENT-SPEC>
				<SW-COMPONENTS>
					<SW-FEATURE>
						<SHORT-NAME>CAN</SHORT-NAME>
						<LONG-NAME>
							<L-4 L="EN">CAN Monitoring am Demonstrator einrichten</L-4>
						</LONG-NAME>
						<DESC>
							<L-2 L="EN" />
						</DESC>
						<CATEGORY>FCT</CATEGORY>
						<SW-FEATURE-VARIANT>
							<SHORT-NAME>CAN</SHORT-NAME>
						</SW-FEATURE-VARIANT>
						<!--
						<CHAPTER>
							<SHORT-NAME>Overview</SHORT-NAME>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>CAN Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						-->
						<CHAPTER>
							<SHORT-NAME>CAN_Monitoring_am_Demonstrator_einrichten</SHORT-NAME>						
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>CAN_CATS_Epm_nEng.Main</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="EN">
											CAN Monitoring am Demonstrator einrichten
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="JPG" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>

							<CHAPTER>
								<SHORT-NAME>Anschluss</SHORT-NAME>
								<P>
									<L-1 L="EN">
										Der linke untere Anschluss am CESIG ist für das CAN
										Monitoring vorgesehen.
										Das Kabel ist mit der Buchse CAN2 am
										ES592 verbunden.

									</L-1>
								</P>
							</CHAPTER>

							<CHAPTER>
								<SHORT-NAME>Einstellungen in der Hardware Konfiguration</SHORT-NAME>
								<P>
									<L-1 L="EN">
										Das ES592 markieren.Hardware hinzufügen (1) (großes
										Bild unten).In der Auswahl [ES592 -- CAN -- CAN-Monitoring]
										auswählen (kleines Bild).
									</L-1>
								</P>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>can_pic1</SHORT-NAME>
										<LONG-NAME>
											<L-4 L="DE">
												1
											</L-4>
										</LONG-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>

								<P>
									<L-1 L="EN">Die Schnittstelle auf CAN2 einstellen (3).Die
										Übertragungsrate ist 1.000.000 Baud (4).
									</L-1>
								</P>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>can_pic2</SHORT-NAME>
										<LONG-NAME>
											<L-4 L="DE">
												2
											</L-4>
										</LONG-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>
								<P>
									<L-1 L="EN">
										Die Verbindung initialisieren und prüfen, ob die
										Verbindung als geschlossen angezeigt wird (grünes Symbol bei
										2).
									</L-1>
								</P>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Variablen für das INCA Experiment</SHORT-NAME>
								<P>
									<L-1 L="EN">
										Folgende Variablen zur Inbetriebnahme, zum
										Applizieren und zum Testen der CAN Funktionalität ins
										Experiment aufnehmen.
									</L-1>
								</P>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>can_pic3</SHORT-NAME>
										<LONG-NAME>
											<L-4 L="DE">
												3
											</L-4>
										</LONG-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>
								<P>
									<L-1 L="EN">
										CAN_ChID_Enable schaltet die Möglichkeit ein / aus,
										eine CAN ID für das Steuergerät zu vergeben. CAN_ChID_MsgId
										ist die ID des Steuergerätes im CAN Verbund.
									</L-1>
								</P>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>can_pic4</SHORT-NAME>
										<LONG-NAME>
											<L-4 L="DE">
												4
											</L-4>
										</LONG-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>
								<P>
									<L-1 L="EN">
										ECU1_EngineSpeed ist die Motordrehzahl des
										Steuergerätes 1 über CAN; die zugehörige Steuergeräte-Variable
										ist Epm_rpmEngSpd.
									</L-1>
								</P>
								<P>
									<L-1 L="EN">
										ECU1_TestParam ist ein applizierbarer Testparameter,
										um den Übertrag von der Steuergeräte-Software-Funktion in den
										CAN zu demonstrieren.
									</L-1>
								</P>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>can_pic5</SHORT-NAME>
										<LONG-NAME>
											<L-4 L="DE">
												5
											</L-4>
										</LONG-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>
								<P>
									<L-1 L="EN">
										CAN_Test_Param ist der Test-Parameter, der mittels
										CAN Monitoring vom CAN in die Variable ECU1_TestParam gelesen
										wird.
									</L-1>
								</P>
								<P>
									<L-1 L="EN">
										CAN_Node_Select ist die Knoten-Identifikation; hier
										ist es die Information an das Steuergerät, dass auf CAN2
										zugegriffen wird. Der Wert muss auf CAN_B stehen.
									</L-1>
								</P>
								<P>
									<L-1 L="EN">
										Damit über CAN Monitoring gemessen werden kann, muss
										die Zündung ein sein. Damit ist der CAN Controller des
										Steuergerätes aktiv. Damit Werte übertragen werden, muss eine
										Motordrehzahl von mindestens 700 rpm anliegen, damit die
										Drehzahl abhängigen Steuergeräte Funktionen arbeiten.
									</L-1>
								</P>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Mehrere Steuergeräte im Verbund</SHORT-NAME>
								<P>
									<L-1 L="EN">
										Werden mehrere Steuergeräte zu einem Verbund
										zusammengeschlossen, ist darauf zu achten, dass jedem
										Steuergerät eine eigene CAN_ChID_MsgId zugewiesen wird.
									</L-1>
								</P>
								<P>
									<L-1 L="EN">
										Der Wertebereich für CAN_ChID_MsgId liegt zwischen
									</L-1>
								</P>
								<P>
									<L-1 L="EN">
										hex 100...10E
									</L-1>
								</P>
								<P>
									<L-1 L="EN">
										phys 256...270
									</L-1>
								</P>
								<P>
									<L-1 L="EN">
										Wird ein anderer Wert für CAN_ChID_MsgId eingetragen
										als hex 100, müssen folgende Parameter dazu passend ausgewählt
										werden. Die Parameter sind einfach durchnummeriert.
									</L-1>
								</P>
								<P>
									<L-1 L="EN">
										hex 100 ==&gt; ECU1_EngineSpeed; ECU1_TestParam
									</L-1>
								</P>
								<P>
									<L-1 L="EN">
										hex 101 ==&gt; ECU2_EngineSpeed; ECU2_TestParam
									</L-1>
								</P>
								<P>
									<L-1 L="EN">
										...
									</L-1>
								</P>
							</CHAPTER>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>Steuergeräte Flash über CAN programmieren</SHORT-NAME>
							<P>
								<L-1 L="EN">
									Stromversorgung anschließen.
								</L-1>
							</P>
							<P>
								<L-1 L="EN">
									Hostleitung anschließen.
								</L-1>
							</P>
							<P>
								<L-1 L="EN">
									Stromversorgung einschalten.
								</L-1>
							</P>
							<P>
								<L-1 L="EN">
									Warten, bis am CESIG u.a. der "WG-PWM" Text
									erscheint.
								</L-1>
							</P>
							<P>
								<L-1 L="EN">
									Warten, bis am ES420 die grüne Leuchtdiode
									durchgehend leuchtet.
								</L-1>
							</P>
							<P>
								<L-1 L="EN">
									batt+ auf EIN.
								</L-1>
							</P>
							<P>
								<L-1 L="EN">
									ignition auf EIN.
								</L-1>
							</P>
							<P>
								<L-1 L="EN">
									Einstellungen in der Hardware-Konfiguration VOR dem
									Flash-Vorgang.
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>can_pic6</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											6
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
									Das Flash-Kabel (D-Sub 9) ist am rechten unteren
									Anschluss des CESIG angeschlossen und mit der CAN1 Buchse des
									ES592 verbunden.
									Die Geschwindigkeit des CAN1 wird später
									mittels der Flash-Konfiguration (Prof-Conf) eingestellt.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									In INCA in der Hardware-Konfiguration die Hardware
									initialisieren [F3].
									Je nach vorheriger Anschluss-Situation muss
									das Initialisieren wiederholt werden.
									Alle angeschlossenen
									Hardware-Komponenten sollen Verbindung anzeigen.
									Ggf.
									Geräte-Verbindung bestätigen.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Speicherseiten-Verwaltung öffnet.
									Wenn nicht, manuell
									öffnen [Shift + F8].
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die folgenden Einstellungen vornehmen.
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>can_pic7</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											7
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
									Gewünschte HEX Datei auswählen.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Zur Sicherheit zuerst die Customer Boot Information
									aus dem Steuergerät LESEN (3).
									Damit wird sichergestellt, dass
									die Verbindung zum Steuergerät funktioniert.
									Ist das der Fall,
									wird auch der Flash-Prozess ablaufen. Dazu die folgenden
									Einstellungen vornehmen.
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>can_pic8</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											8
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
									Die Ignition on/off Meldung kann in diesem Fall
									ignoriert werden.
									Wichtig ist die Information, dass der
									Lesevorgang erfolgreich war.
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>can_pic9</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											9
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
									Den Dialog schließen.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									In der Speicherseitenverwaltung den Prozess mit
									denselben Einstellungen wie oben erneut starten.
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>can_pic10</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											10
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
									HEX Datei auswählen.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Jetzt das Programmieren von Application Software
									(ASW) und Dataset (DS) anstoßen.
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>can_pic11</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											11
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
									Die Speicherblöcke werden jetzt gelöscht und dann neu
									programmiert.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Der Fortschritt ist im Ablauf-Fenster gut zu
									verfolgen.
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>can_pic12</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											12
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
									Im Anschluss an den Flashprozess wird Zündung ein/aus
									gefordert, um das SG zurück zu setzen.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Ab jetzt ist die Handhabung wieder ETK-T typisch.
									Ein
									Download der Daten in den ETK RAM stellt dem Steuergerät die
									Parametersätze (Datensätze) zur Verfügung.
									Bei Bedarf kann ein
									Datensatz NACH dem Download in den ETK-Flash übernommen werden.
								</L-1>
							</P>
						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>
