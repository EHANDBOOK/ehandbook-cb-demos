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
						<SHORT-NAME>Operation Mode</SHORT-NAME>
						<LONG-NAME>
							<L-4 L="EN">Operation Mode</L-4>
						</LONG-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>Overview</SHORT-NAME>	
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Opm Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>OperationMode.Main</SHORT-NAME>
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
							<SHORT-NAME>Operationsmodus</SHORT-NAME>	
							<P>
								<L-1 L="DE">
									Die Aufgabe des Modul Operationsmodus (Operationmode)
									besteht in erster Linie darin
									den Motor im Fehlerfall
									schnellstmöglich in einen sicheren Zustand zu bringen. Dazu
									wird:
								</L-1>
							</P>

							<LIST TYPE="UNNUMBER">
								<ITEM>
									<P>
										<L-1 L="DE">die Einspritzung ausgesetzt</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">die Zündung ausgeschaltet</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">die Drosselklappe in Notlaufposition gebracht</L-1>
									</P>
								</ITEM>
							</LIST>

							<P>
								<L-1 L="DE">
									Hierbei wird ein Zustandsautomat (s. Abbildung 5.12)
									verwendet, der drei Zustände Off,
									Normal und IOError enthält.
									Der Zustand Off ist der Startzustand der Motorsteuerung.
									In
									diesem Zustand wird die Aktuatorik mit den Werten des sicheren
									Zustands angesteuert.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Durch setzen des Flags
									<TT TYPE="PRM">Opm_stEngControl</TT>
									auf true wird in den Zustand Normal auf die Aktuatorik
									mit den
									gerechneten Werten der Motorsteuerung oder den manuell
									überschriebenen
									Werten versorgt. Beim Auftritt eines Fehlers aus
									den Sensorik- und Aktuatorik-Modulen
									wird in den Zustand IOError
									gewechselt und die Aktuatorik in den sicheren Zustand
									geschaltet.
									Erst nach Beseitigung des Fehlers kann mittels
									<TT TYPE="PRM">Opm_stEngControl</TT>
									= false wieder
									in den Zustand Off geschaltet werden, um von
									vorne zu starten. Der Zustandsautomat
									wird im 100ms-Raster
									ausgeführt.
								</L-1>
							</P>

							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>sm_OpMode.Main</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											sm_OpMode
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
									Zur Fehlererkennung werden die eingehenden Signale mit den
									Fehlerinformationen aus
									den Komponentenmodulen Eih_InputError
									und Eoh_OutputError zunächst aufbereitet.
									Dazu wird im
									1ms-Raster geprüft, ob Fehler vorliegen und gegebenenfalls
									jeweils, getrennt
									nach Sensorik und Aktuatorik, Zähler
									inkrementiert. Sobald einer der Zähler den Grenzwert
									<TT TYPE="PRM">Opm_tiIOErrorDelay</TT>
									(Zeit bis Erkennung in Sekunden) erreicht, wird das
									entsprechende
									Flag
									<TT TYPE="VARIABLE">Opm_flgInputErrorMem</TT>
									oder
									<TT TYPE="VARIABLE">Opm_flgOutputErrorMem</TT>
									auf true gesetzt und auch
									nach einem Rücksetzen der Zähler (kein
									Fehler mehr vorhanden) beibehalten. Der Zustandsautomat
									verwendet diese Informationen zur Evaluation und wechselt mit
									Auftreten
									eines Fehlers am Eingang in den Zustand IOError. In
									der Variablen
									<TT TYPE="VARIABLE">Opm_flgIOErrorAct</TT>
									steht der aktuelle Fehlerzustand, also ob aktuell ein Fehler
									vorhanden ist oder nicht. Sie
									wird verwendet um zu Prüfen, ob
									noch ein Fehler vorliegt oder bei Wunsch in den Zustand
									Off
									gewechselt werden darf. Mit diesem Wechsel werden dann die
									Fehlerspeicher
									<TT TYPE="VARIABLE">Opm_flgInputErrorMem</TT>
									und
									<TT TYPE="VARIABLE">Opm_flgOutputErrorMem</TT>
									zurückgesetzt.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die Fehlererkennung kann durch setzen des Flag
									<TT TYPE="PRM">Opm_stIOErrorOverride</TT>
									auf false komplett
									ausgeschaltet werden. Das ist jedoch nicht zu empfehlen, da sehr schnell ein
									unerwartetes
									Verhalten auftreten kann, das zu Schäden am Motor führen kann, wie
									beispielsweise
									einer Sensorstörung bei der Drosselklappe, die zu einem zu großem
									oder zu kleinem
									Öffnungswinkel führt1.
								</L-1>
							</P>

							<P>
								<L-1 L="DE">Die Vorteile dieser Implementierung sind:</L-1>
							</P>
							<LIST TYPE="UNNUMBER">
								<ITEM>
									<P>
										<L-1 L="DE">Durch diese Implementierung kann in einer adäquaten
											Zeit ein Fehlverhalten erkannt
											und mit Abschaltung reagiert werden, ohne dabei sofort bei jedem
											kurzen Störimpuls
											übertrieben zu reagieren.
										</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">Die Aufteilung nach Sensorik und Aktuatorik
											ermöglicht es Fehler schneller zu
											lokalisieren.
										</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">
											Mit Anpassung der Reaktionszeit bis zur Abschaltung
											<TT TYPE="PRM">Opm_tiIOErrorDelay</TT>
											kann
											die „Schärfe“ der Erkennung eingestellt werden.
										</L-1>
									</P>
								</ITEM>
							</LIST>
						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>