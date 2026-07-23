//
//  PickerBridge.swift
//  SwiftUIPicker
//
//  Created by Prateek Mahendrakar on 7/20/26.
//

import Combine
import SwiftUI
import UIKit

// MARK: - PickerBridge

@objc public class PickerBridge: NSObject, ObservableObject {
    
    @Published var selectedItem: String
    private var items: [String]
    private var hostingController: UIHostingController<NativePicker>?

    @objc public var uiView: UIView? {
        hostingController?.view
    }

    @objc public init(items: [String], selected: String) {
        self.items = items
        selectedItem = selected
        super.init()

        let binding = Binding<String>(
            get: { self.selectedItem },
            set: { self.selectedItem = $0 }
        )
        let view = NativePicker(items: items, selectedItem: binding)
        hostingController = UIHostingController(rootView: view)
    }

    @objc public func setSelected(_ item: String) {
        selectedItem = item
    }
}
