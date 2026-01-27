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
						<SHORT-NAME>Actuators Value Treatment</SHORT-NAME>
						<LONG-NAME>
							<L-4 L="EN">Actuators Value Treatment</L-4>
						</LONG-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>Overview</SHORT-NAME>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Actuators Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Actuators.Main.Actuators</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											Komponentenübersicht der Aktuatorik der
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
							<SHORT-NAME>Komponentenmodule der Aktuatorik</SHORT-NAME>
							<LONG-NAME>
								<L-4 L="EN">Komponentenmodule der Aktuatorik</L-4>
							</LONG-NAME>
							<P>
								<L-1 L="DE">
									In den Modulen für die Aktuatorik werden
									physikalische Größen in Daten gewandelt,
									die durch die
									Basissoftware-Schnittstellenklassen als elektrische Signale an
									die Pins der
									FlexECU angelegt werden.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Es wird überwacht, ob der Funktionsaufruf der
									Basissoftware-Schnittstellenklasse erfolgreich ist.
									Die Fehlerflags der einzelnen Komponentenmodule der Aktuatorik
									werden gesammelt und als Nachricht
									an das Funktionsmodul Operationsmodus weitergegeben.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die Funktionen jedes Moduls werden gemäß der Tasklist
									für Bypass-Funktionen aufgerufen.
									Informationen zu den jeweils verwendeten Implementierungsdatentypen und
									Kennlinien und -feldwerten befinden sich in Anhang I.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Abbildung 5.4 zeigt die Hierarchieebene der
									Aktuatorik. Der Anschlussbelegung der Komponenten an die
									FlexECU wird in Anhang B gezeigt.
								</L-1>
							</P>
							<CHAPTER>
								<SHORT-NAME>Drosselklappe</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Drosselklappe</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Das Modul Drosselklappe (ThrottleValve) regelt die
										Position der Drosselklappe. Dazu
										wird in der Hierarchieebene
										ThrottleValvePosition die aktuelle Position ermittelt und
										anschließend, je nach Operationsmodus, die einzuregelnde
										Position.
										Dabei wird aus Sicherheitsgründen der aus den
										Funktionen kommende Stellwert
										dummy_facThrValveReq begrenzt, um
										zu verhindern, dass eine nicht erreichbare
										Position eingeregelt
										werden soll, was zu einer Beschädigung führen kann, da der
										Stellwert
										für den Motor bis zum Maximum erhöht wird.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Der untere Anschlag der Drosselklappe liegt bei rund 4
										<SUP>o</SUP>
										(Faktor -0,12), der obere bei
										weit über 90
										<SUP>o</SUP>
										(Faktor 1,19) und die Ruhelage oder auch Notlaufposition bei
										rund 14
										<SUP>o</SUP>
										(Faktor 0,0). Dabei ist zu beachten, dass jede Drosselklappe
										fertigungsbedingt leicht unterschiedlich
										ist. Die obere Grenze
										der Stellwertlimitierung Tvc_facThrValveLimitMax
										von 1,0
										entspricht einem Öffnungswinkel von 90
										<SUP>o</SUP>
										, also ganz geöffnet, die untere Grenze
										Tvc_facThrValveLimitMin von -0,09 einem von rund 7
										<SUP>o</SUP>
										.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Mit setzen des Flags Tvc_flgThrValveReqOverride kann
										die einzuregelnde Position manuell
										mittels der Variablen
										Tvc_facThrValveReqMan eingestellt werden.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										In der Hierarchie ThrottleValveControl erfolgt die
										Positionsregelung. In die Regelung gehen
										Soll- und Istwert der
										Position ein und das benötigte Tastverhältnis zur Ansteuerung
										der
										H-Brücke (Stellwert) wird berechnet. Die Ausgabe an die
										Aktuatorik erfolgt anschließend
										in ThrottleValveOutput.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Zur Absicherung gegen Fehler findet in den einzelnen
										Teilen eine Fehler- und Plausibilitätsprüfung
										statt. Sobald ein
										Fehlverhalten auftritt, wird das Fehlerflag Tvc_flgError auf
										true gesetzt und als
										Nachricht weitergereicht. Die gesamte Auswertung erfolgt durch die
										Funktion Tvc_set im 10ms-Raster.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Positionserfassung der Drosselklappe
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Die Positionserfassung erfolgt über zwei
										gegenläufige Potentiometer. Es werden beide, an den
										Widerständen der Potentiometer abfallenden, Spannungen
										(Tvc_uSens1 und Tvc_uSens2)
										erfasst und über experimentell
										bestimmte Kennlinien (Tvc_uSens2facThrValve1_CUR und
										Tvc_uSens2facThrValve2_CUR) in Positionen (Tvc_facThrValve1
										und Tvc_facThrValve2)
										umgerechnet. Die Position Tvc_facThrValve
										ergibt sich aus dem Mittelwert der beiden
										Einzelpositionen.
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
										von
										kleiner 5% geprüft. Sobald ein Fehlverhalten auftritt, wird
										das Fehlerflag Tvc_flgPosError
										auf true gesetzt.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Positionsregelung der Drosselklappe
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Die Positionsregelung erfolgt mit einem PID-Regler.
										Eingang ist die
										Regeldifferenz zwischen Soll- und Istwert,
										Ausgang das benötigte Tastverhältnis.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Die Auslegung des Reglers erfolgt nach den
										Erfahrungsregeln zur Einstellung von PIDReglern nach Chien,
										Hrones, Reswick für Führungsverhalten.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Gründe dafür sind:
									</L-1>
								</P>
								<LIST TYPE="UNNUMBER">
									<ITEM>
										<P>
											<L-1 L="DE">Unkenntnis des Blockschaltbilds</L-1>
										</P>
									</ITEM>
									<ITEM>
										<P>
											<L-1 L="DE">Unkenntnis der Übertragungsfunktion</L-1>
										</P>
									</ITEM>
									<ITEM>
										<P>
											<L-1 L="DE">Unkenntnis der Parameter</L-1>
										</P>
									</ITEM>
									<ITEM>
										<P>
											<L-1 L="DE">Nichtlinearitäten, wie Reibung und
												Stellgrößenbegrenzung</L-1>
										</P>
									</ITEM>
									<ITEM>
										<P>
											<L-1 L="DE">Regelstrecke mit Ausgleich und guter Dämpfung
											</L-1>
										</P>
									</ITEM>
								</LIST>
								<P>
									<L-1 L="DE">
										Abbildung 5.5 zeigt den Sprung des Tastverhältnisses
										(rot) und die Sprungantwort der
										Regelstrecke (grün) und die
										daraus abgeleitete Berechnung der Reglerparameter. Abbildung
										5.6 zeigt den Sprung der Soll-Position (rot) von Null auf Eins
										und die Sprungantwort
										der Positionsregelung (rot). Damit wird
										die, aus Erfahrungswerten bestimmte, Einregelzeit
										von rund
										100ms erreicht. Die Abtastzeit von 10ms ist ebenfalls auf
										Erfahrungswerte
										zurückzuführen.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Problematisch ist die Regelung um die Ruhelage, da
										ein relativ hohes Tastverhältnis
										benötigt wird um die Klappe zu
										bewegen, was durch das Moment der verbauten Torsionsfeder
										zustande kommt, der integrierende Anteil des PID-Reglers
										jedoch relativ viel
										Zeit benötigt um sich von positiven auf
										negative Werte abzubauen und umgekehrt. Zur
										Lösung dieser
										Problematik wird zusätzlich eine Vorsteuerung verwendet, die
										additiv wirkt,
										d. h. bei negativen Sollwerten wird von
										vornherein bereits ein negatives Tastverhältnis
										Tvc_facDutycyclePilotControlNeg und bei positiven Stellwerten
										ein positives Tastverhältnis
										Tvc_facDutycyclePilotControlPos
										vorgegeben. Dadurch wird auch bei kleineren
										Verstärkungsfaktoren eine zügiges einregeln erreicht. Die
										Werte von 2000 und -2000 werden
										aus Erfahrungen heraus
										festgelegt. Die Vorsteuerung, die das System noch schneller
										macht,
										wird bei der Reglerauslegung nicht berücksichtigt und zu
										Null gesetzt.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Durch das Flag Tvc_flgThrValveDutycycleOverride kann
										auf eine manuelle Vorgabe des Tastverhältnisse
										Tvc_facThrValveDutycycleMan umgeschaltet werden. Falls in den
										vorangegangenen
										Berechnungen ein Fehler aufgetreten ist, wird
										der Regler zurückgesetzt.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Signalausgabe der Drosselklappe
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Bei der Ausgabe muss beachtet werden, dass bei
										Tastverhältnis von Null die H-Brücke
										ausgeschaltet wird. Daher
										findet eine Prüfung statt, ob es zwischen -1
										und 1 liegt und
										gegebenenfalls reagiert. Ebenfalls ausgeschaltet wird die
										H-Brücke im
										Fehlerfall oder wenn der Operationsmodus nicht
										Normal ist. Im ausgeschalteten Zustand
										stellt sich die Ruhe-
										bzw. Notlauflage ein.
									</L-1>
								</P>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>actuators_png_1</SHORT-NAME>
										<LONG-NAME>
											<L-4 L="DE">
												Reglerauslegung für die Drosselklappe nach Chien,
												Hrones, Reswick
											</L-4>
										</LONG-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>actuators_png_2</SHORT-NAME>
										<LONG-NAME>
											<L-4 L="DE">
												Sprungantwort der Drosselklappe mit Regler
											</L-4>
										</LONG-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Wastegate</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Wastegate</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Das Modul Wastegate (WasteGate) steuert das Wastegate über ein
										PWM-Signal an.
										Dabei ist das Wastegate bei einem Tastverhältnis
										von Null voll geöffnet und bei einem
										Tastverhältnis von Eins
										komplett geschlossen. Im normalen Operationsmodus kann durch
										Setzen des Flags Wgc_flgWastegateRateOverride das
										Tastverhältnis manuell mittels der
										Variablen
										Wgc_facWasteGateRateMan eingestellt werden.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Zur Absicherung gegen Fehler werden die Statusinformationen der
										Klasse zum Setzen
										des PWM-Signals herangezogen. Sobald ein
										Fehlverhalten auftritt, wird das Fehlerflag
										Wgc_flgError auf
										true gesetzt und als Nachricht weitergereicht.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Die gesamte Auswertung erfolgt durch die Funktion Wgc_set im
										Synchron-Raster.
									</L-1>
								</P>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Einspritzventile</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Einspritzventile</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Mit dem Modul Einspritzventile (InjectionValve) werden die
										Einspritzventile über die
										Basissoftware angesteuert. Zur
										Vereinfachung der Motorsteuerung
										wird auf eine
										zylinderindividuelle Einspritzzeit verzichtet und bei allen
										Zylindern das
										Ventil gleich lange offengelassen, d. h., jeder
										Wert im Feld Ivc_tiInjEffCylInd_Arr wird
										mit Itc_tiInj
										beschrieben. Durch Setzen des Flags Ivc_flgInjTimeOverride
										kann die
										Einspritzzeit manuell mittels der Variablen
										Ivc_tiInjMan eingestellt werden.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Weiterhin wird die batteriespannungsabhängige Verzugszeit übergeben,
										die durch Setzen des
										Flags Ivc_flgBattDelayOverride manuell
										mittels der Variablen Ivc_tiBattDelayMan
										überschrieben werden
										kann.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Aus Sicherheitsgründen wird geprüft, ob der normale
										Operationsmodus ausgeführt wird
										und gegebenenfalls das Muster
										111111112 zur Einspritzabschaltung aller Zylinder gesetzt.
										Sonst wird je nach Nachricht Itc_flgInjCutoff eine Abschaltung
										durchgeführt.
										Durch Setzen des Flags Ivc_flgInjCutoffOverride
										kann die Einspritzung manuell durch
										Ivc_flgInjCutoffMan an- und
										abgeschaltet werden.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Zur Absicherung gegen Fehler werden die Statusinformationen der
										Klasse zum Setzen der
										Werte für die Saugrohreinspritzung
										herangezogen. Sobald ein Fehlverhalten auftritt, wird
										das
										Fehlerflag Ivc_flgError auf true gesetzt und als Nachricht
										weitergereicht.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Die Funktion Ivc_set wird im Synchron-Raster ausgeführt. Der
										Vollständigkeit halber wird
										die Funktion Ivc_Diag_set im
										100ms-Raster ausgeführt, wobei die Diagnoseinformationen
										im
										Folgenden nicht weiter verwendet werden.
									</L-1>
								</P>
								<NOTE NOTE-TYPE="HINT">
									<P>
										<L-1 L="DE">
											Die aktuellste Version von EHOOKS befindet sich
											noch im Entwicklungsstadium
											und es ist aufgrund eines
											Initialisierungsfehlers bei der Kompilierung nicht
											möglich,
											Parameterfelder zu verwenden. Daher wird bei der
											Implementierung des
											Feldes mit den Einspritzendwinkeln weea
											der etwas umständlichere Weg gewählt,
											das Variablenfeld
											Ivc_degInjEnd mit Parametern zu beschreiben und dann zu
											übergeben.
										</L-1>
									</P>
									<P>
										<L-1 L="DE">
											Während der Arbeit wurden diverse Fehler im
											Saugrohreinspritz-Modul der
											Basissoftware festgestellt.
											Beispielsweise ist unklar wann und wie der Modus von
											Simultanstart auf normale Operation umgeschaltet wird und
											welche Auswirkungen
											einige Parameter auf das Verhalten haben.
										</L-1>
									</P>
								</NOTE>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Zündspulen</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Zündspulen</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Mit dem Modul Zündspulen (IgnitionCoil) werden die
										Zündspulen über die Basissoftware
										angesteuert. Zur
										Vereinfachung der Motorsteuerung wird auf einen
										zylinderindividuellen Zündwinkel verzichtet und auf alle
										Zylindern zugleich gezündet, d. h.,
										jeder Wert im Feld
										Icc_degIgn_Arr wird mit Iac_degIgn beschrieben. Durch setzen
										des
										Flags Icc_flgIgnAngleOverride kann der Zündwinkel manuell
										mittels der Variablen
										Icc_degIgnMan eingestellt werden.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Aus Sicherheitsgründen wird geprüft, ob der normale
										Operationsmodus ausgeführt wird
										und gegebenenfalls eine
										Aussetzung der Zündung veranlasst. Ansonsten wird je nach
										Nachricht
										Icc_flgIgnCutoff eine Abschaltung durchgeführt.
										Außerdem kann durch setzen des
										Flags Icc_flgIgnCutoffOverride
										die Zündung manuell durch Icc_flgIgnCutoffMan anund
										abgeschaltet werden. Dies geschiet jeweils bei einer fallenden
										Signalflanke durch die
										Funktion fadeout. Sobald kein
										Abschaltewunsch mehr vorliegt, findet eine Wiedereinsetzung
										mit einer steigenden Signalflanke durch die Funktion fadeIn
										statt. In der Variablen
										Icc_stIgnFadeOutReq kann der aktuelle
										Zustand der Abschaltung verfolgt werden.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Zur Absicherung gegen Fehler werden die
										Statusinformationen der Klasse zum Setzen der
										Werte für die
										Zündung herangezogen. Sobald ein Fehlverhalten auftritt, wird
										das Fehlerflag
										Icc_flgError auf true gesetzt und als Nachricht
										weitergereicht.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Die Funktion Icc_set wird im Synchron-Raster
										ausgeführt.
									</L-1>
								</P>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Wasserkühler</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Wasserkühler</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Mit dem Modul Wasserkühler (WaterCooler) wird der
										Lüfter des Wasserkühlers, je nach
										Kühlmitteltemperatur
										Ctc_atCool, über einen Hystereseschalter, an- und
										ausgeschaltet.
										Durch setzen des Flags
										Wcs_flgWaterCoolerOverride kann der Lüfter manuell durch
										Wcs_flgWaterCoolerMan geschalten werden.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Da es sich um einen „Low-Side-Switch“ handelt, wird
										das Signal Wcs_stWaterCooler
										invertiert, bevor es ausgegeben
										wird. Zur Absicherung gegen Fehler werden die
										Statusinformationen
										der Klasse zum Setzen der Digitalausgänge
										herangezogen. Sobald ein Fehlverhalten
										auftritt, wird das
										Fehlerflag Wcs_flgError auf true gesetzt und als Nachricht
										weitergereicht.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Die Funktion Wcs_set wird im 100ms-Raster
										ausgeführt.
									</L-1>
								</P>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Hauptrelais</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Hauptrelais</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Mit dem Modul Hauptrelais (MainRelais) wird das
										Hauptrelais des Steuergeräts geschalten.
										In der Regel ist das
										Hauptrelais während des Betriebs des Steuergeräts immer
										eingeschaltet
										und wird nur zum Abschalten verwendet. Das
										Steuergerät kann sich damit selbst Ausschalten,
										nachdem
										beispielsweise ein Nachlauf zum Speichern von Werten im
										EEPROM1 erfolgt
										ist. Durch setzen des Flags
										Mrs_flgMainRelaisOverride kann das Steuergerät manuell
										durch
										Ivc_flgMainRelaisMan (an- und) abgeschaltet werden.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Da es sich um einen „Low-Side-Switch“ handelt, wird
										das Signal Mrs_stMainRelais invertiert,
										bevor es ausgegeben
										wird. Zur Absicherung gegen Fehler werden die
										Statusinformationen
										der Klasse zum Setzen der Digitalausgänge
										herangezogen. Sobald ein Fehlverhalten
										auftritt, wird das
										Fehlerflag Mrs_flgError auf true gesetzt und als Nachricht
										weitergereicht.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Die Funktion Mrs_set wird im 100ms-Raster
										ausgeführt.
									</L-1>
								</P>
								<NOTE NOTE-TYPE="HINT">
									<P>
										<L-1 L="DE">
											Zum Zeitpunkt der Arbeit ist das Modul zum Nachlauf
											(Afterrun &amp; Shutdown) in
											der Basissoftware noch nicht
											vollständig implementiert. Das Steuergerät schaltet
											sich immer
											ca. 5sek nach Abschalten von Klemme 15 aus und ein Schalten
											des Hauptrelais mit diesem Modul bewirkt nichts. Es wird für
											spätere Zwecke
											implementiert.
										</L-1>
									</P>
								</NOTE>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Kraftstoffpumpe</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Kraftstoffpumpe</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Das Modul Kraftstoffpumpe (FuelPump) ist, mit
										angepasster Benennung, analog zum Modul Hauptrelais
										aufgebaut und wird daher nicht extra vertieft.
									</L-1>
								</P>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Ladeluftkühler</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Ladeluftkühler</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Das Modul Ladeluftkühler (Intercooler) ist, mit
										angepasster Benennung, analog zum Modul Hauptrelais
										aufgebaut
										und wird daher nicht extra vertieft.
									</L-1>
								</P>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Sekundärluftpumpe</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Sekundärluftpumpe</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Das Modul Sekundärluftpumpe
										(AirInjectionReactorPump) ist, mit angepasster
										Benennung,analog zum Modul Hauptrelais
										aufgebaut und wird daher
										nicht extra vertieft.
									</L-1>
								</P>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Umschaltventil Sekundärluft</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Umschaltventil Sekundärluft</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Das Modul Umschaltventil Sekundärluft (AirPumpValve)
										steuert ein Ventil über ein PWMSignal
										an. Dabei ist das Ventil
										bei einem Tastverhältnis von Null voll geöffnet und bei
										einem
										Tastverhältnis von Eins komplett geschlossen. Im normalen
										Operationsmodus kann
										durch setzen des Flags
										Apv_flgAirPumpRateOverride das Tastverhältnis manuell mittels
										der Variablen Apv_facAirPumpRateMan eingestellt werden.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Zur Absicherung gegen Fehler werden die
										Statusinformationen der Klasse zum Setzen
										des PWM-Signals
										herangezogen. Sobald ein Fehlverhalten auftritt, wird das
										Fehlerflag
										Apv_flgError auf true gesetzt und als Nachricht
										weitergereicht.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Die gesamte Auswertung erfolgt durch die Funktion
										Apv_set im 100ms-Raster.
									</L-1>
								</P>
								<NOTE NOTE-TYPE="HINT">
									<P>
										<L-1 L="DE">
											Im Verlauf der Arbeit konnte die genaue Aufgabe des
											Ventils nicht vollständig
											geklärt werden. Eine Vermutung ist,
											dass es sich um ein Unterdruckventil handelt,
											d. h., mit dem
											PWM-Signal wird festgelegt wie viel Druck auf das eigentliche
											Ventil gegeben wird, um damit die Öffnung festzulegen.
										</L-1>
									</P>
								</NOTE>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Umschaltventil Druckgeber</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Umschaltventil Druckgeber</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Das Modul Umschaltventil Druckgeber
										(ChangeOverValve) ist, mit angepasster Benennung,
										analog zum
										Modul Umschaltventil Sekundärluft aufgebaut und wird
										daher
										nicht extra vertieft. Es handelt sich dabei um dasselbe
										Ventil.
									</L-1>
								</P>
								<NOTE NOTE-TYPE="HINT">
									<P>
										<L-1 L="DE">
											Im Verlauf der Arbeit konnte die genaue Aufgabe des
											Ventils nicht vollständig
											geklärt werden. Eine Vermutung ist,
											dass damit gesteuert wird, woher der Druck
											für das
											Umschaltventil Sekundärluft kommt. Im Falle eines Unterdrucks
											kann
											der Druck dem Saugrohr entnommen werden, bei
											vorherrschendem Ladedruck
											wird dann mit diesem auf eine andere
											Quelle vor dem Saugrohr umgeschaltet.
										</L-1>
									</P>
								</NOTE>
							</CHAPTER>
						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>
