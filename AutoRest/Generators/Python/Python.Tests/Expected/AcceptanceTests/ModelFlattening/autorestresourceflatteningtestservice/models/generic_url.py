# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class GenericUrl(Model):
    """
    The Generic URL.

    :param generic_value: Generic URL value.
    :type generic_value: str
    """ 

    _attribute_map = {
        'generic_value': {'key': 'generic_value', 'type': 'str'},
    }

    def __init__(self, generic_value=None, **kwargs):
        self.generic_value = generic_value
