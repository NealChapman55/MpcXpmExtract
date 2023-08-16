namespace MpcXpmExtract
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class MPCVObject
    {

        private MPCVObjectVersion versionField;

        private MPCVObjectProgram programField;

        /// <remarks/>
        public MPCVObjectVersion Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public MPCVObjectProgram Program
        {
            get
            {
                return this.programField;
            }
            set
            {
                this.programField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MPCVObjectVersion
    {

        private decimal file_VersionField;

        private string applicationField;

        private string application_VersionField;

        private string platformField;

        /// <remarks/>
        public decimal File_Version
        {
            get
            {
                return this.file_VersionField;
            }
            set
            {
                this.file_VersionField = value;
            }
        }

        /// <remarks/>
        public string Application
        {
            get
            {
                return this.applicationField;
            }
            set
            {
                this.applicationField = value;
            }
        }

        /// <remarks/>
        public string Application_Version
        {
            get
            {
                return this.application_VersionField;
            }
            set
            {
                this.application_VersionField = value;
            }
        }

        /// <remarks/>
        public string Platform
        {
            get
            {
                return this.platformField;
            }
            set
            {
                this.platformField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MPCVObjectProgram
    {

        private string nameField;

        private decimal pitchField;

        private byte tuneCoarseField;

        private byte tuneFineField;

        private string monoField;

        private MPCVObjectProgramInstrument[] instrumentsField;

        private MPCVObjectProgramPadNote[] padNoteMapField;

        private MPCVObjectProgramPadGroup[] padGroupMapField;

        private MPCVObjectProgramPadColorGroup[] padColorGroupMapField;

        private MPCVObjectProgramQlinks qlinksField;

        private string typeField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public decimal Pitch
        {
            get
            {
                return this.pitchField;
            }
            set
            {
                this.pitchField = value;
            }
        }

        /// <remarks/>
        public byte TuneCoarse
        {
            get
            {
                return this.tuneCoarseField;
            }
            set
            {
                this.tuneCoarseField = value;
            }
        }

        /// <remarks/>
        public byte TuneFine
        {
            get
            {
                return this.tuneFineField;
            }
            set
            {
                this.tuneFineField = value;
            }
        }

        /// <remarks/>
        public string Mono
        {
            get
            {
                return this.monoField;
            }
            set
            {
                this.monoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Instrument", IsNullable = false)]
        public MPCVObjectProgramInstrument[] Instruments
        {
            get
            {
                return this.instrumentsField;
            }
            set
            {
                this.instrumentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PadNote", IsNullable = false)]
        public MPCVObjectProgramPadNote[] PadNoteMap
        {
            get
            {
                return this.padNoteMapField;
            }
            set
            {
                this.padNoteMapField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PadGroup", IsNullable = false)]
        public MPCVObjectProgramPadGroup[] PadGroupMap
        {
            get
            {
                return this.padGroupMapField;
            }
            set
            {
                this.padGroupMapField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PadColorGroup", IsNullable = false)]
        public MPCVObjectProgramPadColorGroup[] PadColorGroupMap
        {
            get
            {
                return this.padColorGroupMapField;
            }
            set
            {
                this.padColorGroupMapField = value;
            }
        }

        /// <remarks/>
        public MPCVObjectProgramQlinks Qlinks
        {
            get
            {
                return this.qlinksField;
            }
            set
            {
                this.qlinksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MPCVObjectProgramInstrument
    {

        private byte audioRouteSubIndexField;

        private string insertsEnabledField;

        private decimal volumeField;

        private string muteField;

        private decimal panField;

        private short tuneCoarseField;

        private short tuneFineField;

        private string monoField;

        private decimal filterKeytrackField;

        private byte lowNoteField;

        private byte highNoteField;

        private string ignoreBaseNoteField;

        private byte zonePlayField;

        private byte muteGroupField;

        private byte muteTarget1Field;

        private byte muteTarget2Field;

        private byte muteTarget3Field;

        private byte muteTarget4Field;

        private byte simultTarget1Field;

        private byte simultTarget2Field;

        private byte simultTarget3Field;

        private byte simultTarget4Field;

        private decimal lfoPitchField;

        private decimal lfoCutoffField;

        private decimal lfoVolumeField;

        private decimal lfoPanField;

        private string oneShotField;

        private byte filterTypeField;

        private decimal cutoffField;

        private decimal resonanceField;

        private decimal filterEnvAmtField;

        private decimal afterTouchToFilterField;

        private decimal velocityToStartField;

        private decimal velocityToFilterAttackField;

        private decimal velocityToFilterField;

        private decimal velocityToFilterEnvelopeField;

        private decimal filterAttackField;

        private decimal filterDecayField;

        private decimal filterSustainField;

        private decimal filterReleaseField;

        private decimal volumeAttackField;

        private decimal volumeDecayField;

        private decimal volumeSustainField;

        private decimal volumeReleaseField;

        private decimal velocityToPitchField;

        private decimal velocityToVolumeAttackField;

        private decimal velocitySensitivityField;

        private decimal velocityToPanField;

        private decimal send1Field;

        private decimal send2Field;

        private decimal send3Field;

        private decimal send4Field;

        private MPCVObjectProgramInstrumentLFO lFOField;

        private MPCVObjectProgramInstrumentLayer[] layersField;

        private byte numberField;

        /// <remarks/>
        public byte AudioRouteSubIndex
        {
            get
            {
                return this.audioRouteSubIndexField;
            }
            set
            {
                this.audioRouteSubIndexField = value;
            }
        }

        /// <remarks/>
        public string InsertsEnabled
        {
            get
            {
                return this.insertsEnabledField;
            }
            set
            {
                this.insertsEnabledField = value;
            }
        }

        /// <remarks/>
        public decimal Volume
        {
            get
            {
                return this.volumeField;
            }
            set
            {
                this.volumeField = value;
            }
        }

        /// <remarks/>
        public string Mute
        {
            get
            {
                return this.muteField;
            }
            set
            {
                this.muteField = value;
            }
        }

        /// <remarks/>
        public decimal Pan
        {
            get
            {
                return this.panField;
            }
            set
            {
                this.panField = value;
            }
        }

        /// <remarks/>
        public short TuneCoarse
        {
            get
            {
                return this.tuneCoarseField;
            }
            set
            {
                this.tuneCoarseField = value;
            }
        }

        /// <remarks/>
        public short TuneFine
        {
            get
            {
                return this.tuneFineField;
            }
            set
            {
                this.tuneFineField = value;
            }
        }

        /// <remarks/>
        public string Mono
        {
            get
            {
                return this.monoField;
            }
            set
            {
                this.monoField = value;
            }
        }

        /// <remarks/>
        public decimal FilterKeytrack
        {
            get
            {
                return this.filterKeytrackField;
            }
            set
            {
                this.filterKeytrackField = value;
            }
        }

        /// <remarks/>
        public byte LowNote
        {
            get
            {
                return this.lowNoteField;
            }
            set
            {
                this.lowNoteField = value;
            }
        }

        /// <remarks/>
        public byte HighNote
        {
            get
            {
                return this.highNoteField;
            }
            set
            {
                this.highNoteField = value;
            }
        }

        /// <remarks/>
        public string IgnoreBaseNote
        {
            get
            {
                return this.ignoreBaseNoteField;
            }
            set
            {
                this.ignoreBaseNoteField = value;
            }
        }

        /// <remarks/>
        public byte ZonePlay
        {
            get
            {
                return this.zonePlayField;
            }
            set
            {
                this.zonePlayField = value;
            }
        }

        /// <remarks/>
        public byte MuteGroup
        {
            get
            {
                return this.muteGroupField;
            }
            set
            {
                this.muteGroupField = value;
            }
        }

        /// <remarks/>
        public byte MuteTarget1
        {
            get
            {
                return this.muteTarget1Field;
            }
            set
            {
                this.muteTarget1Field = value;
            }
        }

        /// <remarks/>
        public byte MuteTarget2
        {
            get
            {
                return this.muteTarget2Field;
            }
            set
            {
                this.muteTarget2Field = value;
            }
        }

        /// <remarks/>
        public byte MuteTarget3
        {
            get
            {
                return this.muteTarget3Field;
            }
            set
            {
                this.muteTarget3Field = value;
            }
        }

        /// <remarks/>
        public byte MuteTarget4
        {
            get
            {
                return this.muteTarget4Field;
            }
            set
            {
                this.muteTarget4Field = value;
            }
        }

        /// <remarks/>
        public byte SimultTarget1
        {
            get
            {
                return this.simultTarget1Field;
            }
            set
            {
                this.simultTarget1Field = value;
            }
        }

        /// <remarks/>
        public byte SimultTarget2
        {
            get
            {
                return this.simultTarget2Field;
            }
            set
            {
                this.simultTarget2Field = value;
            }
        }

        /// <remarks/>
        public byte SimultTarget3
        {
            get
            {
                return this.simultTarget3Field;
            }
            set
            {
                this.simultTarget3Field = value;
            }
        }

        /// <remarks/>
        public byte SimultTarget4
        {
            get
            {
                return this.simultTarget4Field;
            }
            set
            {
                this.simultTarget4Field = value;
            }
        }

        /// <remarks/>
        public decimal LfoPitch
        {
            get
            {
                return this.lfoPitchField;
            }
            set
            {
                this.lfoPitchField = value;
            }
        }

        /// <remarks/>
        public decimal LfoCutoff
        {
            get
            {
                return this.lfoCutoffField;
            }
            set
            {
                this.lfoCutoffField = value;
            }
        }

        /// <remarks/>
        public decimal LfoVolume
        {
            get
            {
                return this.lfoVolumeField;
            }
            set
            {
                this.lfoVolumeField = value;
            }
        }

        /// <remarks/>
        public decimal LfoPan
        {
            get
            {
                return this.lfoPanField;
            }
            set
            {
                this.lfoPanField = value;
            }
        }

        /// <remarks/>
        public string OneShot
        {
            get
            {
                return this.oneShotField;
            }
            set
            {
                this.oneShotField = value;
            }
        }

        /// <remarks/>
        public byte FilterType
        {
            get
            {
                return this.filterTypeField;
            }
            set
            {
                this.filterTypeField = value;
            }
        }

        /// <remarks/>
        public decimal Cutoff
        {
            get
            {
                return this.cutoffField;
            }
            set
            {
                this.cutoffField = value;
            }
        }

        /// <remarks/>
        public decimal Resonance
        {
            get
            {
                return this.resonanceField;
            }
            set
            {
                this.resonanceField = value;
            }
        }

        /// <remarks/>
        public decimal FilterEnvAmt
        {
            get
            {
                return this.filterEnvAmtField;
            }
            set
            {
                this.filterEnvAmtField = value;
            }
        }

        /// <remarks/>
        public decimal AfterTouchToFilter
        {
            get
            {
                return this.afterTouchToFilterField;
            }
            set
            {
                this.afterTouchToFilterField = value;
            }
        }

        /// <remarks/>
        public decimal VelocityToStart
        {
            get
            {
                return this.velocityToStartField;
            }
            set
            {
                this.velocityToStartField = value;
            }
        }

        /// <remarks/>
        public decimal VelocityToFilterAttack
        {
            get
            {
                return this.velocityToFilterAttackField;
            }
            set
            {
                this.velocityToFilterAttackField = value;
            }
        }

        /// <remarks/>
        public decimal VelocityToFilter
        {
            get
            {
                return this.velocityToFilterField;
            }
            set
            {
                this.velocityToFilterField = value;
            }
        }

        /// <remarks/>
        public decimal VelocityToFilterEnvelope
        {
            get
            {
                return this.velocityToFilterEnvelopeField;
            }
            set
            {
                this.velocityToFilterEnvelopeField = value;
            }
        }

        /// <remarks/>
        public decimal FilterAttack
        {
            get
            {
                return this.filterAttackField;
            }
            set
            {
                this.filterAttackField = value;
            }
        }

        /// <remarks/>
        public decimal FilterDecay
        {
            get
            {
                return this.filterDecayField;
            }
            set
            {
                this.filterDecayField = value;
            }
        }

        /// <remarks/>
        public decimal FilterSustain
        {
            get
            {
                return this.filterSustainField;
            }
            set
            {
                this.filterSustainField = value;
            }
        }

        /// <remarks/>
        public decimal FilterRelease
        {
            get
            {
                return this.filterReleaseField;
            }
            set
            {
                this.filterReleaseField = value;
            }
        }

        /// <remarks/>
        public decimal VolumeAttack
        {
            get
            {
                return this.volumeAttackField;
            }
            set
            {
                this.volumeAttackField = value;
            }
        }

        /// <remarks/>
        public decimal VolumeDecay
        {
            get
            {
                return this.volumeDecayField;
            }
            set
            {
                this.volumeDecayField = value;
            }
        }

        /// <remarks/>
        public decimal VolumeSustain
        {
            get
            {
                return this.volumeSustainField;
            }
            set
            {
                this.volumeSustainField = value;
            }
        }

        /// <remarks/>
        public decimal VolumeRelease
        {
            get
            {
                return this.volumeReleaseField;
            }
            set
            {
                this.volumeReleaseField = value;
            }
        }

        /// <remarks/>
        public decimal VelocityToPitch
        {
            get
            {
                return this.velocityToPitchField;
            }
            set
            {
                this.velocityToPitchField = value;
            }
        }

        /// <remarks/>
        public decimal VelocityToVolumeAttack
        {
            get
            {
                return this.velocityToVolumeAttackField;
            }
            set
            {
                this.velocityToVolumeAttackField = value;
            }
        }

        /// <remarks/>
        public decimal VelocitySensitivity
        {
            get
            {
                return this.velocitySensitivityField;
            }
            set
            {
                this.velocitySensitivityField = value;
            }
        }

        /// <remarks/>
        public decimal VelocityToPan
        {
            get
            {
                return this.velocityToPanField;
            }
            set
            {
                this.velocityToPanField = value;
            }
        }

        /// <remarks/>
        public decimal Send1
        {
            get
            {
                return this.send1Field;
            }
            set
            {
                this.send1Field = value;
            }
        }

        /// <remarks/>
        public decimal Send2
        {
            get
            {
                return this.send2Field;
            }
            set
            {
                this.send2Field = value;
            }
        }

        /// <remarks/>
        public decimal Send3
        {
            get
            {
                return this.send3Field;
            }
            set
            {
                this.send3Field = value;
            }
        }

        /// <remarks/>
        public decimal Send4
        {
            get
            {
                return this.send4Field;
            }
            set
            {
                this.send4Field = value;
            }
        }

        /// <remarks/>
        public MPCVObjectProgramInstrumentLFO LFO
        {
            get
            {
                return this.lFOField;
            }
            set
            {
                this.lFOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Layer", IsNullable = false)]
        public MPCVObjectProgramInstrumentLayer[] Layers
        {
            get
            {
                return this.layersField;
            }
            set
            {
                this.layersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MPCVObjectProgramInstrumentLFO
    {

        private string typeField;

        private decimal rateField;

        private byte syncField;

        private string resetField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public decimal Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public byte Sync
        {
            get
            {
                return this.syncField;
            }
            set
            {
                this.syncField = value;
            }
        }

        /// <remarks/>
        public string Reset
        {
            get
            {
                return this.resetField;
            }
            set
            {
                this.resetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MPCVObjectProgramInstrumentLayer
    {

        private string activeField;

        private decimal volumeField;

        private decimal panField;

        private decimal pitchField;

        private short tuneCoarseField;

        private short tuneFineField;

        private byte velStartField;

        private byte velEndField;

        private byte sampleStartField;

        private byte sampleEndField;

        private string loopField;

        private byte loopStartField;

        private byte loopEndField;

        private byte loopTuneField;

        private string muteField;

        private byte rootNoteField;

        private string keyTrackField;

        private string sampleNameField;

        private object sampleFileField;

        private byte numberField;

        /// <remarks/>
        public string Active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        public decimal Volume
        {
            get
            {
                return this.volumeField;
            }
            set
            {
                this.volumeField = value;
            }
        }

        /// <remarks/>
        public decimal Pan
        {
            get
            {
                return this.panField;
            }
            set
            {
                this.panField = value;
            }
        }

        /// <remarks/>
        public decimal Pitch
        {
            get
            {
                return this.pitchField;
            }
            set
            {
                this.pitchField = value;
            }
        }

        /// <remarks/>
        public short TuneCoarse
        {
            get
            {
                return this.tuneCoarseField;
            }
            set
            {
                this.tuneCoarseField = value;
            }
        }

        /// <remarks/>
        public short TuneFine
        {
            get
            {
                return this.tuneFineField;
            }
            set
            {
                this.tuneFineField = value;
            }
        }

        /// <remarks/>
        public byte VelStart
        {
            get
            {
                return this.velStartField;
            }
            set
            {
                this.velStartField = value;
            }
        }

        /// <remarks/>
        public byte VelEnd
        {
            get
            {
                return this.velEndField;
            }
            set
            {
                this.velEndField = value;
            }
        }

        /// <remarks/>
        public byte SampleStart
        {
            get
            {
                return this.sampleStartField;
            }
            set
            {
                this.sampleStartField = value;
            }
        }

        /// <remarks/>
        public byte SampleEnd
        {
            get
            {
                return this.sampleEndField;
            }
            set
            {
                this.sampleEndField = value;
            }
        }

        /// <remarks/>
        public string Loop
        {
            get
            {
                return this.loopField;
            }
            set
            {
                this.loopField = value;
            }
        }

        /// <remarks/>
        public byte LoopStart
        {
            get
            {
                return this.loopStartField;
            }
            set
            {
                this.loopStartField = value;
            }
        }

        /// <remarks/>
        public byte LoopEnd
        {
            get
            {
                return this.loopEndField;
            }
            set
            {
                this.loopEndField = value;
            }
        }

        /// <remarks/>
        public byte LoopTune
        {
            get
            {
                return this.loopTuneField;
            }
            set
            {
                this.loopTuneField = value;
            }
        }

        /// <remarks/>
        public string Mute
        {
            get
            {
                return this.muteField;
            }
            set
            {
                this.muteField = value;
            }
        }

        /// <remarks/>
        public byte RootNote
        {
            get
            {
                return this.rootNoteField;
            }
            set
            {
                this.rootNoteField = value;
            }
        }

        /// <remarks/>
        public string KeyTrack
        {
            get
            {
                return this.keyTrackField;
            }
            set
            {
                this.keyTrackField = value;
            }
        }

        /// <remarks/>
        public string SampleName
        {
            get
            {
                return this.sampleNameField;
            }
            set
            {
                this.sampleNameField = value;
            }
        }

        /// <remarks/>
        public object SampleFile
        {
            get
            {
                return this.sampleFileField;
            }
            set
            {
                this.sampleFileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MPCVObjectProgramPadNote
    {

        private byte noteField;

        private byte numberField;

        /// <remarks/>
        public byte Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MPCVObjectProgramPadGroup
    {

        private byte groupField;

        private byte numberField;

        /// <remarks/>
        public byte Group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MPCVObjectProgramPadColorGroup
    {

        private byte groupField;

        private byte numberField;

        /// <remarks/>
        public byte Group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MPCVObjectProgramQlinks
    {

        private byte countField;

        private MPCVObjectProgramQlinksQlink[] qlinkField;

        /// <remarks/>
        public byte Count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Qlink")]
        public MPCVObjectProgramQlinksQlink[] Qlink
        {
            get
            {
                return this.qlinkField;
            }
            set
            {
                this.qlinkField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MPCVObjectProgramQlinksQlink
    {

        private byte controllerField;

        private decimal minField;

        private decimal maxField;

        private string touchToMaxField;

        private byte padAssignField;

        private string changeRealTimeField;

        private byte midiControllerField;

        private decimal noteOnValueField;

        private byte numberField;

        /// <remarks/>
        public byte Controller
        {
            get
            {
                return this.controllerField;
            }
            set
            {
                this.controllerField = value;
            }
        }

        /// <remarks/>
        public decimal Min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        public decimal Max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }

        /// <remarks/>
        public string TouchToMax
        {
            get
            {
                return this.touchToMaxField;
            }
            set
            {
                this.touchToMaxField = value;
            }
        }

        /// <remarks/>
        public byte PadAssign
        {
            get
            {
                return this.padAssignField;
            }
            set
            {
                this.padAssignField = value;
            }
        }

        /// <remarks/>
        public string ChangeRealTime
        {
            get
            {
                return this.changeRealTimeField;
            }
            set
            {
                this.changeRealTimeField = value;
            }
        }

        /// <remarks/>
        public byte MidiController
        {
            get
            {
                return this.midiControllerField;
            }
            set
            {
                this.midiControllerField = value;
            }
        }

        /// <remarks/>
        public decimal NoteOnValue
        {
            get
            {
                return this.noteOnValueField;
            }
            set
            {
                this.noteOnValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
    }


}
